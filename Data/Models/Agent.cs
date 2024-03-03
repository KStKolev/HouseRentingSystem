using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HouseRentingSystem.Data.DataRequirements;
using Microsoft.AspNetCore.Identity;

namespace HouseRentingSystem.Data.Models
{
    public class Agent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.MaxAgentPhoneNumberLength, MinimumLength = DataConstants.MinAgentPhoneNumberLength)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]

        public IdentityUser User { get; set; } = null!;

        public IEnumerable<House> Houses { get; set; } = new List<House>();
    }
}
