using System.ComponentModel.DataAnnotations;

namespace Portfolio.wwwroot;

public class ContactModel
{
    // [Required]
    // [RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Entrer une adresse email valide")]
    // public string To { get; set; }

    [Required(ErrorMessage = "L'email du destinataire est obligatoire")]
    public string FromName { get; set; }
        
    [Required(ErrorMessage = "Le nom est obligatoire")]
    public string FromEmail { get; set; }

    [Required(ErrorMessage = "Le sujet est obligatoire")]
    public string Subject { get; set; }

    [StringLength(2000, MinimumLength = 10, ErrorMessage = "Le message doit être entre 10 et 2000 caractères")]
    public string Message { get; set; }
}