using System.ComponentModel.DataAnnotations;

namespace DemoBlazorApp.Shared.Models.InputModels
{
    public class PersonaInputModel
    {
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Il cognome è obbligatorio"),
        Display(Name = "Cognome")]
        public string Cognome { get; set; }

        [Required(ErrorMessage = "Il nome è obbligatorio"),
        Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "L'indirizzo email è obbligatorio"),
        EmailAddress(ErrorMessage = "Devi inserire un indirizzo email"),
        Display(Name = "Indirizzo Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Il telefono è obbligatorio"),
        Display(Name = "Telefono")]
        public string Telefono { get; set; }
    }
}