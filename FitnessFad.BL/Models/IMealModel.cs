using System.Collections.Generic;

namespace FitnessFad.BL.Models
{
    public interface IMealModel
    {
        int Id { get; set; }
        List<IIngredientModel> Ingredients { get; set; }
        string Name { get; set; }

        int GetTotalCalories();
        double GetTotalCarbs();
        double GetTotalFat();
        double GetTotalProtein();
    }
}