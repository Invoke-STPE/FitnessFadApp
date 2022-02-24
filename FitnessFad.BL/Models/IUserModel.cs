using System.Collections.Generic;

namespace FitnessFad.BL.Models
{
    public interface IUserModel
    {
        string Email { get; set; }
        string Id { get; set; }
        List<IMealModel> Meals { get; set; }
        int CalorieGoal { get; set; }

        int GetCurrentCalories();
        double GetCurrentCarbs();
        double GetCurrentFat();
        double GetCurrentProtein();
        double GetProcentOfNumber(double currentNumber, double totalNumber);
        double TotalCarbsGoal();
        double TotalFatGoal();
        double TotalProteinGoal();
    }
}