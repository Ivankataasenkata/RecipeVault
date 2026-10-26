using System.ComponentModel.DataAnnotations;

using static RecipeVault.Common.ValidationConstants;

namespace RecipeVault.Models
{
    public class Cuisine
    {
        // [Key] marks the primary key. EF would also find "Id" by convention,
        // but being explicit makes the model easier to read.
        [Key]
        public int Id { get; set; }

        // [Required] -> NOT NULL column; [MaxLength] -> nvarchar(50) instead of nvarchar(max).
        // MinLength is not a database rule - it is checked later in the view model.
        [Required]
        [MaxLength(CuisineNameMaxLength)]
        public string Name { get; set; } = null!;

        // Nullable (string?) because a description is optional.
        [MaxLength(CuisineDescriptionMaxLength)]
        public string? Description { get; set; }

        // Navigation property: one Cuisine has many Recipes (one-to-many).
        // Recipe will need: int CuisineId + [ForeignKey(nameof(CuisineId))] Cuisine Cuisine.
        public virtual ICollection<Recipe> Recipes { get; set; } = new HashSet<Recipe>();
    }
}
