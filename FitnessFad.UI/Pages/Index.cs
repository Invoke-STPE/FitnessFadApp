using FitnessFad.BL.Data;
using FitnessFad.BL.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using FitnessFad.UI.Models;

namespace FitnessFad.UI.Pages
{
    public partial class Index
    {
        [Inject]
        public IMealDummyDataService MealDataService { get; set; }
        [Inject]
        public IUserDataService UserDataServive { get; set; }
        [Inject]
        public IHttpContextAccessor HttpContext { get; set; }

        public List<IIngredientModel> Ingredients { get; set; } = new List<IIngredientModel>();
        public List<IMealModel> Meals { get; set; } = new List<IMealModel>();
        public IUserModel User { get; set; }
        public IMealModel Meal { get; set; } = new DisplayMealModel();
        public IMealModel TargetMeal { get; set; }


        protected async override Task OnInitializedAsync()
        {
            Meals = await MealDataService.GetMeals();
            var userId = HttpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            User = await UserDataServive.GetUsers(userId);
        }

        private async  Task OnHandleCreateMeal()
        {
            IMealModel meal = await MealDataService.CreateMeal(Meal);
            User.Meals.Add(meal);
        }

        private void HandleOnChosen(IIngredientModel ingredient)
        {
            if (ingredient != null)
            {
                TargetMeal.Ingredients.Add(ingredient);
                InvokeAsync(StateHasChanged);
            }
        }

        private void SetTargetMeal(IMealModel targetMeal)
        {
            TargetMeal = targetMeal;
        }


    }
}
