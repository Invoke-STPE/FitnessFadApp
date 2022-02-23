using FitnessFad.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessFad.UI.Models
{
    public class DisplayIngredientModel : IIngredientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public double Carbs { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Gram { get; set; }

        public string DisplayCalories()
        {
            return $"{Calories} kcal";
        }
        public string DisplayCarbs()
        {
            return $"{Carbs}g";
        }
        public string DisplayProtein()
        {
            return $"{Protein}g";
        }
        public string DisplayFat()
        {
            return $"{Fat}g";
        }
    }
}
