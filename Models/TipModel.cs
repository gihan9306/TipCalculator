using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace GihanTipCalculator.Models
{
    public class TipModel
    {
        [BindRequired]
        [Required(ErrorMessage = "Meal cost is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Meal cost must be greater than 0")]

        public decimal? MealCost { get; set; } // Cost of the meal

        // Calculate tip amount
        public decimal CalculateTip(decimal percent)
        {
            return Math.Round((MealCost ?? 0) * percent, 2); // Round to 2 decimals
        }
    }
}
