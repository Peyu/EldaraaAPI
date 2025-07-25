namespace EldaraaApi.Models
{
    public class AtributoPersonalizado
    {
        public int Id { get; set; }
        public int PersonajeId { get; set; }
        public Personaje Personaje { get; set; }
        public string Nombre { get; set; }           // Nombre del atributo
        public string? Valor { get; set; }           // Valor libre (puede ser texto o numérico)
        public string? Detalles { get; set; }        // Explicación narrativa o descriptiva
        public string? Sistema { get; set; }         // Cómo impacta en el juego (reglas, dados, etc.)
    }
}
