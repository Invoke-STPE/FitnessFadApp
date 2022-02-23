using System.Collections.Generic;

namespace FitnessFad.BL.Models
{
    public interface IUserModel
    {
        string Email { get; set; }
        string Id { get; set; }
        List<IMealModel> Meals { get; set; }
    }
}