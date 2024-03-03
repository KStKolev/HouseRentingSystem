using HouseRentingSystem.Data.DataRequirements;
using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.CategoryMaxNameLength)]
        public string Name { get; set; } = string.Empty;

        public IEnumerable<House> Houses { get; set; } = new List<House>();


    }
}
