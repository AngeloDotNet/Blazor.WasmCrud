using DemoBlazorApp.Server.Entities;
using DemoBlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBlazorApp.Server.Models.Services.Application.Persone
{
    public class EfCorePersonaService : IPersonaService
    {
        private readonly ILogger<EfCorePersonaService> logger;
        private readonly BlazorAppDbContext dbContext;

        public EfCorePersonaService(ILogger<EfCorePersonaService> logger, BlazorAppDbContext dbContext)
        {
            this.logger = logger;
            this.dbContext = dbContext;
        }

        public async Task<List<PersonaViewModel>> ElencoPersone()
        {
            var entities = await dbContext.Persone.ToListAsync();

            List<PersonaViewModel> lista = new();

            lista = entities.Select(t => new PersonaViewModel
             {
                 Nome = t.Nome,
                 Cognome = t.Cognome,
                 Email = t.Email,
                 Telefono = t.Telefono,
                 PersonaId = t.PersonaId,
             }).ToList();

            return lista;
        }

        public async Task AggiungiPersona(PersonaViewModel persona)
        {
            dbContext.Add(persona);
            await dbContext.SaveChangesAsync();
        }

        public async Task<PersonaViewModel> DatiPersona(int id)
        {
            var item = await dbContext.Persone.FindAsync(id);

            PersonaViewModel persona = new();

            persona.PersonaId = item.PersonaId;
            persona.Cognome = item.Cognome;
            persona.Nome = item.Nome;
            persona.Email = item.Email;
            persona.Telefono = item.Telefono;
            
            return persona;
        }

        public async Task ModificaPersona(PersonaViewModel persona)
        {
            var personaOld = await dbContext.Persone.FindAsync(persona.PersonaId);
            if (personaOld == null)
                return;

            personaOld.Telefono = persona.Telefono;
            personaOld.Cognome = persona.Cognome;
            personaOld.Email = persona.Email;
            personaOld.Nome = persona.Nome;
            await dbContext.SaveChangesAsync();
        }

        public async Task CancellaPersona(int id)
        {
            var personaOld = await dbContext.Persone.FindAsync(id);
            if (personaOld == null)
                return;

            dbContext.Persone.Remove(personaOld);
            await dbContext.SaveChangesAsync();
        }
    }
}