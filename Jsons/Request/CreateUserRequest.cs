using System.ComponentModel.DataAnnotations;

namespace Dental_Clinic.Jsons.Request
{
    public class CreateUserRequest
    {
        [Required(ErrorMessage = "Fied Login is required")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Fied Password is required")]
        public string Password { get; set; }
    }
}
