namespace EldaraaApi.Models
{
    public class Raza
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }

        public ICollection<Subraza>? Subrazas { get; set; }
        public ICollection<Personaje>? Personajes { get; set; }
    }
}
