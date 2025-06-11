using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace zd3_Rydnyh
{
    public partial class Form1 : Form
    {
        // Объект для управления списком продуктов
        private FoodManager _foodManager = new FoodManager();

        // Источник данных для привязки к таблице
        private BindingSource _bindingSource = new BindingSource();

        // Конструктор формы — вызывается при запуске программы
        public Form1()
        {
            InitializeComponent(); // Подключаем элементы дизайна из конструктора

            ShowData();      // Настройка колонок таблицы
            UpdateBinding(); // Привязываем данные и обновляем отображение
        }

        // Настраивает внешний вид таблицы (DataGridView)
        private void ShowData()
        {
            // Отключаем автоматическое создание колонок
            dataGridView1.AutoGenerateColumns = false;

            // Очищаем старые колонки, если они были
            dataGridView1.Columns.Clear();

            // Создаём и добавляем колонки таблицы

            var colName = new DataGridViewTextBoxColumn
            {
                HeaderText = "Название",
                DataPropertyName = "Name" // Привязка к свойству Name
            };

            var colProtein = new DataGridViewTextBoxColumn
            {
                HeaderText = "Белки",
                DataPropertyName = "Protein" // Привязка к свойству Protein
            };

            var colCarbs = new DataGridViewTextBoxColumn
            {
                HeaderText = "Углеводы",
                DataPropertyName = "Carbs" // Привязка к свойству Carbs
            };

            var colCalories = new DataGridViewTextBoxColumn
            {
                HeaderText = "Калории",
                DataPropertyName = "Calories" // Привязка к свойству Calories
            };

            var colQuality = new DataGridViewTextBoxColumn
            {
                HeaderText = "Качество",
                DataPropertyName = "Quality" // Привязка к вычисляемому свойству Quality
            };

            // Добавляем колонки в таблицу
            dataGridView1.Columns.Add(colName);
            dataGridView1.Columns.Add(colProtein);
            dataGridView1.Columns.Add(colCarbs);
            dataGridView1.Columns.Add(colCalories);
            dataGridView1.Columns.Add(colQuality);

            // Привязываем список продуктов к таблице
            _bindingSource.DataSource = _foodManager.FoodList;
            dataGridView1.DataSource = _bindingSource;
        }

        // Обновляет источник данных и перерисовывает таблицу
        private void UpdateBinding()
        {
            _bindingSource.DataSource = _foodManager.FoodList;
            _bindingSource.ResetBindings(false); // Обновляем отображение
        }

        // Событие: нажатие кнопки "Добавить обычный продукт"
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text.Trim();
                string proteinStr = textBoxBel.Text.Trim();
                string carbsStr = textBoxYg.Text.Trim();

                if (!ValidateInput(name, proteinStr, carbsStr, out double protein, out double carbs)) return;

                _foodManager.AddFood(name, protein, carbs); // Добавляем обычный продукт
                UpdateBinding(); // Обновляем таблицу
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении продукта: " + ex.Message);
            }
        }

        // Событие: нажатие кнопки "Добавить расширенный продукт"
        private void buttonAddKal_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text.Trim();
                string proteinStr = textBoxBel.Text.Trim();
                string carbsStr = textBoxYg.Text.Trim();
                string caloriesStr = textBoxKal.Text.Trim();

                if (!ValidateInput(name, proteinStr, carbsStr, out double protein, out double carbs) ||
                    !ValidateNumber(caloriesStr, "Калории", out double calories)) return;

                _foodManager.AddKallorFood(name, protein, carbs, calories); // Добавляем калорийный продукт
                UpdateBinding(); // Обновляем таблицу
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении расширенного продукта: " + ex.Message);
            }
        }

        // Событие: нажатие кнопки "Удалить"
        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index; // Получаем индекс выбранной строки
                _foodManager.RemoveFood(index); // Удаляем по индексу
                UpdateBinding(); // Обновляем таблицу
            }
        }

        // Событие: нажатие кнопки "Фильтровать"
        private void buttonFil_Click(object sender, EventArgs e)
        {
            string input = textBoxQ.Text.Trim(); // Получаем значение Q

            if (!double.TryParse(input, out double q))
            {
                MessageBox.Show("Введите корректное число для фильтрации качества.");
                return;
            }

            var filtered = _foodManager.FilterByQuality(q); // Фильтруем список
            _bindingSource.DataSource = filtered; // Показываем только подходящие продукты
            _bindingSource.ResetBindings(false); // Обновляем отображение
        }

        // Событие: нажатие кнопки "Сбросить фильтр"
        private void buttonFilDel_Click(object sender, EventArgs e)
        {
            _bindingSource.DataSource = _foodManager.GetFullList(); // Возвращаем полный список
            _bindingSource.ResetBindings(false); // Обновляем таблицу
        }

        // --- Вспомогательные методы проверки ввода ---

        // Проверяет основные поля: название, белки, углеводы
        private bool ValidateInput(string name, string proteinStr, string carbsStr,
                                   out double protein, out double carbs)
        {
            protein = carbs = 0;

            // Проверяем название
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите название продукта.");
                return false;
            }
            else if (!Regex.IsMatch(name, @"^[a-zA-Zа-яА-ЯёЁ\s]+$"))
            {
                MessageBox.Show("Название должно содержать только буквы.");
                return false;
            }

            // Проверяем белки
            if (!ValidateNumber(proteinStr, "Белки", out protein))
                return false;

            // Проверяем углеводы
            if (!ValidateNumber(carbsStr, "Углеводы", out carbs))
                return false;

            return true;
        }

        // Проверяет числовое значение
        private bool ValidateNumber(string valueStr, string fieldName, out double value)
        {
            value = 0;

            // Проверяем, что поле не пустое
            if (string.IsNullOrWhiteSpace(valueStr))
            {
                MessageBox.Show($"Введите количество {fieldName}.");
                return false;
            }

            // Проверяем формат числа (с точкой или запятой)
            if (!Regex.IsMatch(valueStr, @"^[0-9]+([.,][0-9]+)?$"))
            {
                MessageBox.Show($"{fieldName} должны быть положительным числом.");
                return false;
            }

            // Преобразуем строку в число
            value = double.Parse(valueStr.Replace(',', '.'));

            return true;
        }
    }
}