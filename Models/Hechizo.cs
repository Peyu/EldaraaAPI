namespace EldaraaApi.Models
{
    public class Hechizo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public string? Escuela { get; set; }
        public string? TiempoConjuro { get; set; }
        public string? Alcance { get; set; }
        public string? Componentes { get; set; }
        public string? Duracion { get; set; }
        public string? Descripcion { get; set; }
        public ICollection<PersonajeHechizo>? PersonajesHechizo { get; set; }
    }
}
