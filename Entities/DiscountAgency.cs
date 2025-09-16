using System.ComponentModel.DataAnnotations;

namespace CityinBooking.Api.Entities
{
    public class DiscountAgency
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string DiscountId { get; set; }
        public virtual Discount Discount { get; set; }

        [Required]
        public string SubAgencyId { get; set; }
        public virtual SubAgency SubAgency { get; set; }

        public DateTime AssignedAt { get; set; }

        // Optional: You can add additional properties specific to this relationship
        // public string AssignedBy { get; set; }
        // public string Notes { get; set; }
    }
}