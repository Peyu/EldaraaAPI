namespace EldaraaApi.Models
{
    public class Habilidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? HabilidadBase { get; set; } // STR, DEX, etc.
        public ICollection<PersonajeHabilidad>? PersonajesHabilidad { get; set; }
    }
}
