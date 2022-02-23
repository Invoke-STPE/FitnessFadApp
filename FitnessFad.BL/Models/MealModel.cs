using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessFad.BL.Models
{
    public class MealModel : IMealModel
    {
        public MealModel()
        {

        }
        public MealModel(int id, string name, List<IIngredientModel> ingredients)
        {
            Id = id;
            Name = name;
            Ingredients = ingredients;
        }

        public MealModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<IIngredientModel> Ingredients { get; set; } = new List<IIngredientModel>();
        public int GetTotalCalories()
        {
            int totalCalories = 0;
            foreach (var ingredent in Ingredients)
            {
                totalCalories += ingredent.Calories;
            }
            return totalCalories;
        }
        public double GetTotalCarbs()
        {
            double totalCarbs = 0;
            foreach (var ingredent in Ingredients)
            {
                totalCarbs += ingredent.Carbs;
            }
            return Math.Round(totalCarbs, 2);
        }
        public double GetTotalProtein()
        {
            double totalProtein = 0;
            foreach (var ingredent in Ingredients)
            {
                totalProtein += ingredent.Protein;
            }
            return Math.Round(totalProtein, 2);
        }
        public double GetTotalFat()
        {
            double totalFat = 0;
            foreach (var ingredent in Ingredients)
            {
                totalFat += ingredent.Fat;
            }
            return Math.Round(totalFat, 2);
        }
    }

}
