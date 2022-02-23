using FitnessFad.BL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FitnessFad.BL.Data
{
    public interface IIngredientDataService
    {
        Task<List<IIngredientModel>> GetIngredients();
    }
}