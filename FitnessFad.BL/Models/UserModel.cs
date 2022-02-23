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
    }
}
