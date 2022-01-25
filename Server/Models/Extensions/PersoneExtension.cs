using DemoBlazorApp.Shared.Models.ViewModels;
using DemoBlazorApp.Server.Models.Entities;

namespace DemoBlazorApp.Server.Models.Extensions
{
    public static class PersoneExtension
    {
        public static PersonaViewModel ToPersonaViewModel(this PersonaEntity persona)
        {
            return new PersonaViewModel
            {
                PersonaId = persona.PersonaId,
                Cognome = persona.Cognome,
                Nome = persona.Nome,
                Email = persona.Email,
                Telefono = persona.Telefono
            };
        }
    }
}
