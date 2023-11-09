using Microsoft.AspNetCore.Mvc;

public class FormularioController : Controller
{
  [HttpPost]
  public IActionResult EnviarFormulario([FromForm] FormularioModel dadosFormulario)
  {
    var validator = new FormularioValidador();
    ValidationResult result = validator.Validate(dadosFormulario);

    if (!result.IsValid)
    {
      return BadRequest(result.Errors);
    }

    return Ok("Sucesso!");
  }
}
