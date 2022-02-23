using FitnessFad.BL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessFad.BL.Data
{
    public class MealDummyDataService : IMealDummyDataService
    {
        private List<IMealModel> meals = new List<IMealModel>();
        private static int id = 0;

        public MealDummyDataService()
        {
            meals.Add(
                new MealModel(++id, "Breakfast", new List<IIngredientModel>() {
                new IngredientModel(++id, "Egg", 137, 1.2, 12.3, 9.2),
                new IngredientModel(++id, "Bread", 223, 40.1, 7.9, 1.7),
                new IngredientModel(++id, "Orange Juice", 42, 9.7, 0.6, 0.1),
            }));

            meals.Add(
              new MealModel(++id, "Lunch", new List<IIngredientModel>() {
                new IngredientModel(++id, "Egg", 137, 1.2, 12.3, 9.2),
                new IngredientModel(++id, "Bread", 223, 40.1, 7.9, 1.7),
                new IngredientModel(++id, "Orange Juice", 42, 9.7, 0.6, 0.1),
          }));

            meals.Add(
              new MealModel(++id, "Dinner", new List<IIngredientModel>() {
                new IngredientModel(++id, "Egg", 137, 1.2, 12.3, 9.2),
                new IngredientModel(++id, "Bread", 223, 40.1, 7.9, 1.7),
                new IngredientModel(++id, "Orange Juice", 42, 9.7, 0.6, 0.1),
          }));

        }

        public Task<List<IMealModel>> GetMeals()
        {
            return Task.FromResult(meals);
        }

        public async Task<IMealModel> CreateMeal(IMealModel newMeal) 
        {
            IMealModel meal = new MealModel(++id, newMeal.Name);
            meals.Add(meal);
            return await Task.FromResult(meal);
        }
    }
}
