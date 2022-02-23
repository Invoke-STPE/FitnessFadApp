using FitnessFad.BL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FitnessFad.BL.Data
{
    public interface IMealDummyDataService
    {
        Task<IMealModel> CreateMeal(IMealModel newMeal);
        Task<List<IMealModel>> GetMeals();
    }
}