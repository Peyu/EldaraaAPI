namespace EldaraaApi.Models
{
    public class EntradaLibre
    {
        public int Id { get; set; }
        public int PersonajeId { get; set; }
        public Personaje Personaje { get; set; }
        public string? Titulo { get; set; }
        public string Contenido { get; set; }
        public DateTime CreadoEn { get; set; } = DateTime.UtcNow;
        public DateTime ActualizadoEn { get; set; } = DateTime.UtcNow;
    }
}
