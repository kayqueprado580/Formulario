using Microsoft.AspNetCore.Mvc;

public class FormularioController : Controller
{
  [HttpPost]
  public IActionResult EnviarFormulario([FromForm] FormularioModel dadosFormulario)
  {
    if (!ModelState.IsValid)
      return BadRequest(ModelState);

    string mensagemSucesso = "Olá, ";
    mensagemSucesso += dadosFormulario.Nome;
    mensagemSucesso += ". Formulário recebido com sucesso!";

    return Ok(mensagemSucesso);
  }
}
