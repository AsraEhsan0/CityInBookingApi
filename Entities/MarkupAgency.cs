using System.ComponentModel.DataAnnotations;

namespace CityinBooking.Api.Entities
{
    public class MarkupAgency
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string MarkupId { get; set; }
        public virtual Markup Markup { get; set; }

        [Required]
        public string SubAgencyId { get; set; }
        public virtual SubAgency SubAgency { get; set; }

        public DateTime AssignedAt { get; set; }

        // Optional: You can add additional properties specific to this relationship
        // public string AssignedBy { get; set; }
        // public string Notes { get; set; }
    }
}