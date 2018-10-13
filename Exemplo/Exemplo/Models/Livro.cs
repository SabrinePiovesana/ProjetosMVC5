using System.ComponentModel.DataAnnotations;

namespace Example.Models
{
    public class Livro
    {     
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Digite o título do livro")]
        [StringLength(100, ErrorMessage ="O tamanho máximo de caracteres é {1}", MinimumLength=3)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Digite o autor do livro")]
        public string Autor { get; set; }

        public decimal Preco { get; set; }

        public int Estoque { get; set; }

        public bool Disponivel { get; set; }
    }
}