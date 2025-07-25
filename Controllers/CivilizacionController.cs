using EldaraaApi.Data;
using EldaraaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EldaraaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CivilizacionController : ControllerBase
    {
        private readonly EldaraaDbContext _db;

        public CivilizacionController(EldaraaDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetCivilizaciones()
        {
            var civilizaciones = _db.Civilizaciones.ToList();
            return Ok(civilizaciones);
        }

        [HttpPost]
        public IActionResult CrearCivilizacion(Civilizacion civilizacion)
        {
            _db.Civilizaciones.Add(civilizacion);
            _db.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditarCivilizacion(int id, Civilizacion civilizacion)
        {
            if (id != civilizacion.Id)
            {
                return BadRequest("El ID de la URL no coincide con el de la civilización enviada.");
            }

            var existente = await _db.Civilizaciones.FindAsync(id);
            if (existente == null)
            {
                return NotFound();
            }

            existente.Nombre = civilizacion.Nombre;
            existente.Descripcion = civilizacion.Descripcion;

            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarCivilizacion(int id)
        {
            var civilizacion = await _db.Civilizaciones.FindAsync(id);
            if (civilizacion == null)
            {
                return NotFound();
            }

            _db.Civilizaciones.Remove(civilizacion);
            await _db.SaveChangesAsync();
            return Ok();
        }
    }
}
