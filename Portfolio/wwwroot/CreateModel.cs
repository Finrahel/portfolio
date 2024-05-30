using System.ComponentModel.DataAnnotations;

namespace Portfolio.wwwroot;

public class CreateModel
{
    [Required(ErrorMessage = "L'email est obligatoire")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Le nom d'utilisateur est obligatoire")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Le mot de passe est obligatoire")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Le mot de passe est obligatoire"), ]
    public string Password2 { get; set; }
}