using System.ComponentModel.DataAnnotations;

namespace BlazoriseCommunityStandup.ECommerce.Models
{
    public class RecoveryInputModel
    {
        [Required]
        [EmailAddress]
        [Display( Name = "Email" )]
        public string Email { get; set; }
    }
}
