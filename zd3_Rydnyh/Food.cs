using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_Rydnyh
{
    public class Food // Базовый класс
    {
        public string Name { get; set; } // Название продукта
        public double Protein { get; set; }// Белки
        public double Carbs { get; set; }// Углеводы

        public Food(string name, double protein, double carbs) // Сохраняем данные в свойствах
        {
            Name = name;
            Protein = protein;
            Carbs = carbs;
        }

        public virtual double CalculateQuality() // Метод для расчета качества продукта
        {
            return Carbs * 4 + Protein * 4;
        }

        // Вычисляемое свойство для привязки
        public double Quality => CalculateQuality();
    }
}
