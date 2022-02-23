using FitnessFad.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessFad.UI.Models
{
    public class DisplayMealModel : IMealModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IIngredientModel> Ingredients { get; set; }

        public int GetTotalCalories()
        {
            throw new NotImplementedException();
        }

        public double GetTotalCarbs()
        {
            throw new NotImplementedException();
        }

        public double GetTotalFat()
        {
            throw new NotImplementedException();
        }

        public double GetTotalProtein()
        {
            throw new NotImplementedException();
        }
    }
}
