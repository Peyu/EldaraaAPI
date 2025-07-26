using EldaraaApi.Data;
using EldaraaApi.Models;
using EldaraaApi.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EldaraaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajeController : ControllerBase
    {
        private readonly EldaraaDbContext _db;

        public PersonajeController(EldaraaDbContext db)
        {
            _db = db;
        }

        // Obtener todos los personajes
        [HttpGet]
        public IActionResult ObtenerPersonajes()
        {
            var personajes = _db.Personajes
                .Include(p => p.Raza)
                .Include(p => p.Subraza)
                .Include(p => p.Clase)
                .Include(p => p.Trasfondo)
                .ToList();

            return Ok(personajes);
        }

        // Obtener un personaje por ID
        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(int id)
        {
            var personaje = await _db.Personajes
                .Include(p => p.Raza)
                .Include(p => p.Subraza)
                .Include(p => p.Clase)
                .Include(p => p.Trasfondo)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (personaje == null)
                return NotFound();

            return Ok(personaje);
        }

        // Crear nuevo personaje
        [HttpPost]
        public async Task<IActionResult> CrearPersonaje([FromBody] CrearPersonajeDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var nuevo = new Personaje
            {
                Nombre = dto.Nombre,
                NombreJugador = dto.NombreJugador,
                RazaId = dto.RazaId,
                SubrazaId = dto.SubrazaId,
                ClaseId = dto.ClaseId,
                TrasfondoId = dto.TrasfondoId,
                Alineamiento = dto.Alineamiento,
                Edad = dto.Edad,
                Genero = dto.Genero,
                Altura = dto.Altura,
                Peso = dto.Peso,
                ColorOjos = dto.ColorOjos,
                ColorCabello = dto.ColorCabello,
                ColorPiel = dto.ColorPiel,
                Deidad = dto.Deidad,
                HistoriaPersonal = dto.HistoriaPersonal
            };

            _db.Personajes.Add(nuevo);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(ObtenerPorId), new { id = nuevo.Id }, nuevo);
        }

        // Editar personaje existente
        [HttpPut("{id}")]
        public async Task<IActionResult> EditarPersonaje(int id, Personaje personaje)
        {
            if (id != personaje.Id)
            {
                return BadRequest("El ID de la URL no coincide con el personaje enviado.");
            }

            var existente = await _db.Personajes.FindAsync(id);
            if (existente == null)
            {
                return NotFound();
            }

            existente.Nombre = personaje.Nombre;
            existente.NombreJugador = personaje.NombreJugador;
            existente.RazaId = personaje.RazaId;
            existente.SubrazaId = personaje.SubrazaId;
            existente.ClaseId = personaje.ClaseId;
            existente.TrasfondoId = personaje.TrasfondoId;
            existente.Alineamiento = personaje.Alineamiento;
            existente.Edad = personaje.Edad;
            existente.Genero = personaje.Genero;
            existente.Altura = personaje.Altura;
            existente.Peso = personaje.Peso;
            existente.ColorOjos = personaje.ColorOjos;
            existente.ColorPiel = personaje.ColorPiel;
            existente.ColorCabello = personaje.ColorCabello;
            existente.Deidad = personaje.Deidad;
            existente.HistoriaPersonal = personaje.HistoriaPersonal;

            await _db.SaveChangesAsync();
            return Ok();
        }

        // Eliminar personaje
        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarPersonaje(int id)
        {
            var personaje = await _db.Personajes.FindAsync(id);
            if (personaje == null)
            {
                return NotFound();
            }

            _db.Personajes.Remove(personaje);
            await _db.SaveChangesAsync();
            return Ok();
        }
    }
}
