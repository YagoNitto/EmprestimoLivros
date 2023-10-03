using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivro.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do recebedor")]
        public string Recebedor { get; set; }

        [Required(ErrorMessage = "Informe o nome do forncedor")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "Informe o nome do livro")]
        public string LivroEmprestado { get; set; }
        public DateTime dataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
