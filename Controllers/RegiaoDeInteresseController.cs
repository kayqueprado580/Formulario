using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class RegiaoDeInteresseController : ControllerBase
{
    [HttpGet]
    public IActionResult GetRegioesDeInteresse()
    {
        var regioes = RegiaoDeInteresseModel.GetRegiaoDeInteresses();
        var siglasUnicas = regioes.Select(r => r.Sigla).Distinct().ToList();
        var estadosUnicos = regioes.Select(r => r.Estado).Distinct().ToList();
        var regioesUnicas = regioes.Select(r => r.Regiao).Distinct().ToList();

        return Ok(new
        {
            Siglas = siglasUnicas,
            Estados = estadosUnicos,
            Regioes = regioesUnicas,
            RegioesCompleto = regioes
        });
    }
}
