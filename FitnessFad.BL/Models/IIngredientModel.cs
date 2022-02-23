namespace FitnessFad.BL.Models
{
    public interface IIngredientModel
    {
        int Calories { get; set; }
        double Carbs { get; set; }
        double Fat { get; set; }
        double Gram { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        double Protein { get; set; }
    }
}