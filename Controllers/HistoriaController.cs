using Microsoft.AspNetCore.Mvc;
using EldaraaApi.Data;

namespace EldaraaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HistoriaController : ControllerBase
{
    [HttpGet]
    public IActionResult GetHistorias()
    {
        var historias = HistoriaStore.GetHistorias();
        return Ok(historias);
    }
}