using System.ComponentModel.DataAnnotations;

namespace EldaraaApi.Models
{
    public class Civilizacion
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        public string? Descripcion { get; set; }
    }
}
