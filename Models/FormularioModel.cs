using System.ComponentModel.DataAnnotations;

public class FormularioModel
{
    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo Sobrenome é obrigatório.")]
    [StringLength(50, ErrorMessage = "O Sobrenome deve ter no máximo 50 caracteres.")]
    public string Sobrenome { get; set; }

    [Required(ErrorMessage = "O campo Email é obrigatório.")]
    [EmailAddress(ErrorMessage = "O Email não é válido.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "O campo CPF é obrigatório.")]
    [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve ter 11 dígitos numéricos.")]
    public string CPF { get; set; }
    public string Sigla { get; set; }
    public string Estado { get; set; }
    public string Regiao { get; set; }

    [Required(ErrorMessage = "O campo CEP é obrigatório.")]
    [RegularExpression(@"^\d{8}$", ErrorMessage = "O CEP deve ter 8 dígitos numéricos.")]
    public string Cep { get; set; }
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public string Localidade { get; set; }
}
