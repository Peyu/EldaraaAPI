namespace EldaraaApi.Models
{
    public class Personaje
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? NombreJugador { get; set; }

        public int? RazaId { get; set; }
        public Raza? Raza { get; set; }

        public int? SubrazaId { get; set; }
        public Subraza? Subraza { get; set; }

        public int? ClaseId { get; set; }
        public Clase? Clase { get; set; }

        public int? TrasfondoId { get; set; }
        public Trasfondo? Trasfondo { get; set; }

        public string? Alineamiento { get; set; }
        public int Nivel { get; set; } = 1;
        public int Experiencia { get; set; } = 0;
        public bool Inspiracion { get; set; } = false;

        public int? Edad { get; set; }
        public string? Genero { get; set; }
        public string? Altura { get; set; }
        public string? Peso { get; set; }
        public string? ColorOjos { get; set; }
        public string? ColorPiel { get; set; }
        public string? ColorCabello { get; set; }
        public string? Deidad { get; set; }
        public string? HistoriaPersonal { get; set; }

        // Relaciones inversas (opcional por ahora)
        public ICollection<AtributoPersonalizado>? AtributosPersonalizados { get; set; }
        public ICollection<EntradaLibre>? EntradasLibres { get; set; }
    }
}
