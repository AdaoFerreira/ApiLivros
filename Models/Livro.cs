using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLivros.Models;

public class Livro
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(120,ErrorMessage = "O maximo é de 120 caracteres")]
    public string Nome { get; set; }
    [Required]
    public int Paginas { get; set; }
    [MaxLength(100,ErrorMessage = "O maximo é de 100 caracteres")]
    public string Autor { get; set; }
    [Required]
    [MaxLength(70,ErrorMessage = "O maximo é de 70 caracteres")]
    public string Editora { get; set; }
    [Required]
    [MaxLength(60,ErrorMessage = "O máximo é de 60 caracteres")]
    public string Idioma { get; set; }
}
