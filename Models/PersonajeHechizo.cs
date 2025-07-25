namespace EldaraaApi.Models
{
    public class PersonajeHechizo
    {
        public int PersonajeId { get; set; }
        public Personaje Personaje { get; set; }
        public int HechizoId { get; set; }
        public Hechizo Hechizo { get; set; }
        public bool Preparado { get; set; } = false;
    }
}
