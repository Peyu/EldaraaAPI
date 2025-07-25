namespace EldaraaApi.Models
{
    public class Clase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? DadoGolpe { get; set; }
        public bool LanzadorConjuros { get; set; } = false;
        public string? Descripcion { get; set; }
        public ICollection<Personaje>? Personajes { get; set; }
    }
}
