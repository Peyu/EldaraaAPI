using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EldaraaApi.Models
{
    public class PuntuacionHabilidades
    {
        [Key]
        public int PersonajeId { get; set; }

        [ForeignKey(nameof(PersonajeId))]
        public Personaje Personaje { get; set; }
        public int Fuerza { get; set; }
        public int Destreza { get; set; }
        public int Constitucion { get; set; }
        public int Inteligencia { get; set; }
        public int Sabiduria { get; set; }
        public int Carisma { get; set; }
    }
}
