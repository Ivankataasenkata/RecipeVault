using System.ComponentModel.DataAnnotations;

using static RecipeVault.Common.ValidationConstants;

namespace RecipeVault.Models
{
    public class Ingredient
    {
       
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(IngredientNameMaxLength)]
        public string Name { get; set; } = null!;
        public virtual ICollection<RecipeIngredient> RecipeIngredients  { get; set; } = new HashSet<RecipeIngredient>();
    }
}
