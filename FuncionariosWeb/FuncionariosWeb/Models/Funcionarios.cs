
using System.ComponentModel.DataAnnotations;
using FuncionariosWeb.Model;

namespace FuncionariosWeb.Models;

public class Funcionario
{
    public int FuncionarioId { get; set; }

    [Required, MaxLength(80, ErrorMessage = "Nome não pode exceder 80 caracteres")]
    public string Nome { get; set; }

    [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
    ErrorMessage = "Email com formato inválido")]
    [Required]
    public string Email { get; set; }

    public Departamento? Departamento { get; set; }
}