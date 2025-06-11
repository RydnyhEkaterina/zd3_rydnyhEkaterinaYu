using System;
using System.Collections.Generic;
using System.Linq;

namespace zd3_Rydnyh
{
    public class FoodManager
    {
        public List<Food> _foodList = new List<Food>();
        public IReadOnlyList<Food> FoodList => _foodList.AsReadOnly();

        // Добавление обычного продукта
        public void AddFood(string name, double protein, double carbs)
        {
            _foodList.Add(new Food(name, protein, carbs));
        }

        // Добавление калорийного продукта
        public void AddKallorFood(string name, double protein, double carbs, double calories)
        {
            _foodList.Add(new KallorFood(name, protein, carbs, calories));
        }

        // Удаление по индексу
        public void RemoveFood(int index)
        {
            if (index >= 0 && index < _foodList.Count)
            {
                _foodList.RemoveAt(index);
            }
        }

        // Удаление по объекту
        public void RemoveFood(Food food)
        {
            if (food != null && _foodList.Contains(food))
            {
                _foodList.Remove(food);
            }
        }

        // Фильтрация по качеству
        public List<Food> FilterByQuality(double q)
        {
            return _foodList.Where(f => f.CalculateQuality() > q).ToList();
        }

        // Сброс фильтра
        public List<Food> GetFullList()
        {
            return new List<Food>(_foodList);
        }
    }
}