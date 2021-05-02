using System.ComponentModel.DataAnnotations;

namespace ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        public ForgotPasswordViewModel() : base()
        {
        }

        // *****
        [MaxLength(64)]
        [EmailAddress]
        [Display(Name = "EmailAddress")]
        public string Email { get; set; }
        // *****

    }
}
