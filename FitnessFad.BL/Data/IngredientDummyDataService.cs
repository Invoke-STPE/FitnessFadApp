using FitnessFad.BL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessFad.BL.Data
{
    public class IngredientDummyDataService : IIngredientDataService
    {
        private List<IIngredientModel> ingredients = new List<IIngredientModel>();
        private static int id = 0;

        public IngredientDummyDataService()
        {
            ingredients.Add(new IngredientModel(++id, "Egg", 137, 1.2, 12.3, 9.2));
            ingredients.Add(new IngredientModel(++id, "Bread", 223, 40.1, 7.9, 1.7));
            ingredients.Add(new IngredientModel(++id, "Orange Juice", 42, 9.7, 0.6, 0.1));
        }

        public Task<List<IIngredientModel>> GetIngredients()
        {
            return Task.FromResult(ingredients);
        }


    }
}
