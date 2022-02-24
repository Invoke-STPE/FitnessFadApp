using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessFad.BL.Models
{
    public class UserModel : IUserModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public List<IMealModel> Meals { get; set; }
        public int CalorieGoal { get; set; } = 3070;

        public double TotalCarbsGoal()
        {
            double total = (0.50 * CalorieGoal) / 4;
            return Math.Round(total, 1);
        }
        public double TotalProteinGoal()
        {
            double total = (0.30 * CalorieGoal) / 4;
            return Math.Round(total, 1);
        }
        public double TotalFatGoal()
        {
            double total = (0.20 * CalorieGoal) / 9;
            return Math.Round(total, 1);
        }

        public int GetCurrentCalories()
        {
            int currentCalories = 0;
            foreach (var meal in Meals)
            {
                currentCalories += meal.GetTotalCalories();
            }

            return currentCalories;
        }
        public double GetCurrentCarbs()
        {
            double currentCarbs = 0;
            foreach (var meal in Meals)
            {
                currentCarbs += meal.GetTotalCarbs();
            }

            return Math.Round(currentCarbs, 1);
        }
        public double GetCurrentProtein()
        {
            double currentProtein = 0;
            foreach (var meal in Meals)
            {
                currentProtein += meal.GetTotalProtein();
            }

            return Math.Round(currentProtein, 1);
        }
        public double GetCurrentFat()
        {
            double currentFat = 0;
            foreach (var meal in Meals)
            {
                currentFat += meal.GetTotalFat();
            }

            return Math.Round(currentFat, 1);
        }

        public double GetProcentOfNumber(double currentNumber, double totalNumber)
        {
            return (currentNumber / totalNumber) * 100;
        }
    }
}
