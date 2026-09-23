using System.ComponentModel.DataAnnotations;

namespace PSRMS.Models
{
    public class RegisterRequests
    {
        public int Id {get; set;}
        [Required]
        
        public string CompanyName { get; set; } = string.Empty;


        [Required]
        public string BusinessEmail { get; set; } = string.Empty;


        [Required]
        public string ContactNumber { get; set; } = string.Empty;


        [Required]
        public string Industry { get; set; } = string.Empty;


        [Required]
        public string Country { get; set; } = string.Empty;


        
        public string? CompanyWeb { get; set; }


        [Required]
        public string FullName { get; set; } = string.Empty;


        [Required]
        public string Password { get; set; } = string.Empty;


        [Required]
        public string ConfirmPassword { get; set; } = string.Empty;


        public bool TermsAndCondition { get; set; }
    }
}