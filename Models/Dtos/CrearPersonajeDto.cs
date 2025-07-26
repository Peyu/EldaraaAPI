using System.ComponentModel.DataAnnotations;

namespace EldaraaApi.Models.Dtos
{
    public class CrearPersonajeDto
    {
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreJugador { get; set; }

        [Required]
        public int RazaId { get; set; }

        public int? SubrazaId { get; set; }

        [Required]
        public int ClaseId { get; set; }

        [Required]
        public int TrasfondoId { get; set; }

        [StringLength(50)]
        public string? Alineamiento { get; set; }

        [Range(0, 1000)]
        public int? Edad { get; set; }

        [StringLength(20)]
        public string? Genero { get; set; }

        [StringLength(20)]
        public string? Altura { get; set; }

        [StringLength(20)]
        public string? Peso { get; set; }

        [StringLength(30)]
        public string? ColorOjos { get; set; }

        [StringLength(30)]
        public string? ColorCabello { get; set; }

        [StringLength(30)]
        public string? ColorPiel { get; set; }

        [StringLength(50)]
        public string? Deidad { get; set; }

        [StringLength(3000)]
        public string? HistoriaPersonal { get; set; }
    }
}
