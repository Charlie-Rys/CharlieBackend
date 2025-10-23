using System.ComponentModel.DataAnnotations;

namespace CharlieBackend.Application.DTOs.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}