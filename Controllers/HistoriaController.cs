using Microsoft.AspNetCore.Mvc;
using EldaraaApi.Data;
using EldaraaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EldaraaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HistoriaController : ControllerBase
{

    private readonly EldaraaDbContext _db;

    public HistoriaController(EldaraaDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult GetHistorias()
    {
        var historias = _db.Historias.ToList();
        return Ok(historias);
    }

    [HttpPost]
    public IActionResult CrearHistoria(Historia historia)
    {
        _db.Historias.Add(historia);
        _db.SaveChanges();
        return CreatedAtAction(nameof(GetHistorias), new { id = historia.Id }, historia);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> EditarHistoria(int id, Historia historia)
    {
        if (id != historia.Id)
        {
            return BadRequest("El ID de la URL no coincide con el de la historia enviada.");
        }

        var historiaExistente = await _db.Historias.FindAsync(id);
        if (historiaExistente == null)
        {
            return NotFound();
        }

        // Actualizar los campos
        historiaExistente.Titulo = historia.Titulo;
        historiaExistente.Resumen = historia.Resumen;
        historiaExistente.Texto = historia.Texto;

        await _db.SaveChangesAsync();

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> EliminarHistoria(int id)
    {
        var historia = await _db.Historias.FindAsync(id);
        if (historia == null)
        {
            return NotFound();
        }

        _db.Historias.Remove(historia);
        await _db.SaveChangesAsync();

        return Ok();
    }

}