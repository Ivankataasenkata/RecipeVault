using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static RecipeVault.Common.ValidationConstants;

namespace RecipeVault.Models
{
    public class RecipeIngredient
    {
       public int RecipeId {get; set;}

        [ForeignKey(nameof(RecipeId))]
        public virtual Recipe Recipe {get; set;} = null!;

        public int IngredientId {get; set;}

        [ForeignKey(nameof(IngredientId))]
        public virtual Ingredient Ingredient {get; set;} = null!;

        [Required]
        [MaxLength(RecipeIngredientQuantityMaxLength)]
        public string Quantity  { get; set; } = null!;

    }
}