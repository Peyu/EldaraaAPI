namespace EldaraaApi.Models
{
    public class TrasfondoHabilidad
    {
        public int TrasfondoId { get; set; }
        public Trasfondo Trasfondo { get; set; }
        public int HabilidadId { get; set; }
        public Habilidad Habilidad { get; set; }
    }
}
