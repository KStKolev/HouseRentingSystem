using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Data.DataRequirements.DataConstants;

namespace HouseRentingSystem.Data.Models
{
    public class House
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxHouseTitleLength, MinimumLength = MinHouseTitleLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(MaxHouseAddressLength, MinimumLength = MinHouseAddressLength)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [StringLength(MaxHouseDescriptionLength, MinimumLength = MinHouseDescriptionLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PricePerMonth { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public int AgentId { get; set; }
        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;

        public string? RenterId { get; set; }

    }
}
