using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_Rydnyh
{
    public class KallorFood : Food // Класс потомок
    {
        public double Calories { get; set; } // Калории

        public KallorFood(string name, double protein, double carbs, double calories)// Сохраняем данные в свойствах
            : base(name, protein, carbs)
        {
            Calories = calories;
        }
        // Переопределённый метод для расчёта качества продукта Qp с учётом калорийности
        public override double CalculateQuality() 
        {
            return base.CalculateQuality() * 1.2 + Calories * 7;
        }
        // Вычисляемое свойство для привязки
        public double Quality => CalculateQuality();
    }
}
