namespace EldaraaApi.Models
{
    public class PersonajeHabilidad
    {
        public int PersonajeId { get; set; }
        public Personaje Personaje { get; set; }

        public int HabilidadId { get; set; }
        public Habilidad Habilidad { get; set; }

        public bool Competente { get; set; } = false;
    }
}
