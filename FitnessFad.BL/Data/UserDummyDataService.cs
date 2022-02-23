using FitnessFad.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessFad.BL.Data
{
    public class UserDummyDataService : IUserDataService
    {
        private List<IUserModel> users = new List<IUserModel>();

        public UserDummyDataService()
        {

        }

        public Task<List<IUserModel>> GetUsers()
        {
            return Task.FromResult(users);
        }

        public Task<IUserModel> GetUsers(string id)
        {
            IUserModel user = users.Where(x => x.Id == id).FirstOrDefault();

            if (user == null)
            {
                CreateUser(id);
            }
            return Task.FromResult(users.Where(x => x.Id == id).FirstOrDefault());
        }

        private void CreateUser(string id)
        {
            users.Add(new UserModel()
            {
                Id = id,
                Meals = new List<IMealModel>(),
            }) ;

        }
    }
}
