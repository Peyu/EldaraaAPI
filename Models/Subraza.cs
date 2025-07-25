namespace EldaraaApi.Models
{
    public class Subraza
    {
        public int Id { get; set; }
        public int RazaId { get; set; }
        public Raza Raza { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public ICollection<Personaje>? Personajes { get; set; }
    }
}
