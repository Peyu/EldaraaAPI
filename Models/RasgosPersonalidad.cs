using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EldaraaApi.Models
{
    public class RasgosPersonalidad
    {
        [Key]
        public int PersonajeId { get; set; }

        [ForeignKey(nameof(PersonajeId))]
        public Personaje Personaje { get; set; }
        public string? Rasgo1 { get; set; }
        public string? Rasgo2 { get; set; }
        public string? Ideal { get; set; }
        public string? Vinculo { get; set; }
        public string? Defecto { get; set; }
    }
}
