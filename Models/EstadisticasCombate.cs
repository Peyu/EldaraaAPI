using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EldaraaApi.Models
{
    public class EstadisticasCombate
    {
        [Key]
        public int PersonajeId { get; set; }

        [ForeignKey(nameof(PersonajeId))]
        public Personaje Personaje { get; set; }
        public int PuntosGolpeActuales { get; set; }
        public int PuntosGolpeMaximos { get; set; }
        public int Iniciativa { get; set; }
        public int ClaseArmadura { get; set; }
        public int Velocidad { get; set; }
        public string? DadosGolpe { get; set; }
        public string? HabilidadLanzamientoConjuros { get; set; }
        public int? DificultadSalvacionConjuros { get; set; }
        public int? BonoAtaqueConjuros { get; set; }
    }
}
