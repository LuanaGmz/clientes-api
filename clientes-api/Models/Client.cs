using System.ComponentModel.DataAnnotations;

namespace clientes_api.Models
{
    public class Client
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O CPF deve ser informado")]
        [MaxLength(11, ErrorMessage = "O tamanho máximo do CPF não pode exceder 11 caracteres")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "O nome deve ser informado")]
        public string NomeCompleto { get; set; }
        [Required(ErrorMessage = "O e-mail deve ser informado")]
        public string Email { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string NumeroLogradouro { get; set; }
        public string Cidade { get; set; }
        public string SiglaUf { get; set; }
        public string Cep { get; set; }

    }
}
