namespace DemoBlazorApp.Server.Models.Entities
{
    public partial class PersonaEntity
    {
        public int PersonaId { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}