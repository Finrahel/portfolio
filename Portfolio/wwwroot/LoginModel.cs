using System.ComponentModel.DataAnnotations;

namespace Portfolio;

public class LoginModel
{
    [Required(ErrorMessage = "Le nom d'utilisateur est obligatoire")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Le mot de passe est obligatoire")]
    public string Password { get; set; }
}