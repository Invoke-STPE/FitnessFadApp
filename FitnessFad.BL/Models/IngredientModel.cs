using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessFad.BL.Models
{
    public class IngredientModel : IIngredientModel
    {
        public IngredientModel(int id, string name, int calories, double carbs, double protein, double fat)
        {
            Id = id;
            Name = name;
            Calories = calories;
            Carbs = carbs;
            Protein = protein;
            Fat = fat;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public double Carbs { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Gram { get; set; }
    }
}
