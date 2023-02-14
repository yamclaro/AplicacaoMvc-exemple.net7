using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacaoMvc_exemple.Models;

public class Filme
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo titulo é obrigatório")]
    [StringLength(60, MinimumLength = 3, ErrorMessage = "O titulo precisa ter entre 3 ou 60 caracteres")]
    public string? Titulo { get; set; }
    [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
    [Required(ErrorMessage = "O campo data de lançamento é obrigatorio")]
    [Display(Name = "Data de lançamento")]
    public DateTime DataLancamento { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Genero em formato inválido")]
    [StringLength(30, ErrorMessage = "Maximo de 30 Caracteres"), Required(ErrorMessage = "O campo genero é requerido")]

    public string? Genero { get; set; }
    [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000")]
    [Required(ErrorMessage = "Preencha o campo valor")]
    [Column(TypeName = "Decimal(18,2)")]
    public decimal Valor { get; set; }
    [Required(ErrorMessage = "Preencha o campo avaliação")]
    [Display(Name = "Avaliação")]
    [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente numeros")]

    public int Avaliacao { get; set; }
}
