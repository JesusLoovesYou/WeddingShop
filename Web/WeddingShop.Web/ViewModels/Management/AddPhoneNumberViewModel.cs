using System.ComponentModel.DataAnnotations;

namespace WeddingShop.Web.ViewModels.Management
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}