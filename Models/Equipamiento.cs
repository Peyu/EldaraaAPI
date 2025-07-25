namespace EldaraaApi.Models
{
    public class Equipamiento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Tipo { get; set; } // arma, armadura, herramienta, etc.
        public string? Propiedades { get; set; }
        public float? Peso { get; set; }
        public string? Costo { get; set; }
        public string? Descripcion { get; set; }
        public ICollection<PersonajeEquipamiento>? PersonajesEquipamiento { get; set; }
    }
}
