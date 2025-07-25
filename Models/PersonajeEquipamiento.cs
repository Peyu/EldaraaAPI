namespace EldaraaApi.Models
{
    public class PersonajeEquipamiento
    {
        public int PersonajeId { get; set; }
        public Personaje Personaje { get; set; }
        public int EquipamientoId { get; set; }
        public Equipamiento Equipamiento { get; set; }
        public bool Equipado { get; set; } = false;
        public int Cantidad { get; set; } = 1;
    }
}
