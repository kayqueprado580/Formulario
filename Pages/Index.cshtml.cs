using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Location.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string Nome { get; set; }

    [BindProperty]
    public string Sobrenome { get; set; }

    [BindProperty]
    public string Email { get; set; }

    [BindProperty]
    public string CPF { get; set; }

    [BindProperty]
    public string Sigla { get; set; }

    [BindProperty]
    public string Estado { get; set; }

    [BindProperty]
    public string Regiao { get; set; }

    [BindProperty]
    public string Cep { get; set; }

    [BindProperty]
    public string Logradouro { get; set; }

    [BindProperty]
    public string Bairro { get; set; }

    [BindProperty]
    public string Localidade { get; set; }

    public List<RegiaoDeInteresseModel> Regioes { get; set; }

    public IActionResult OnGet()
    {
        Regioes = RegiaoDeInteresseModel.GetRegiaoDeInteresses();

        return Page();
    }

}
