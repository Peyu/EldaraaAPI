namespace EldaraaApi.Models
{
    public class Trasfondo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Caracteristica { get; set; }
        public string? Descripcion { get; set; }
        public ICollection<Personaje>? Personajes { get; set; }
    }
}
