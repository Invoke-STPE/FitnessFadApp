using FitnessFad.BL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FitnessFad.BL.Data
{
    public interface IUserDataService
    {
        Task<List<IUserModel>> GetUsers();
        Task<IUserModel> GetUsers(string id);
    }
}