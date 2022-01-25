using DemoBlazorApp.Shared.Models.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoBlazorApp.Server.Models.Services.Application.Persone
{
    public interface IPersonaService
    {
        Task<List<PersonaViewModel>> ElencoPersone();
        Task AggiungiPersona(PersonaViewModel persona);
        Task ModificaPersona(PersonaViewModel persona);
        Task<PersonaViewModel> DatiPersona(int id);
        Task CancellaPersona(int id);
    }
}