using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string Senha { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataNascimento { get; set; }

        public DateTime DataCriacao { get; set; } = DateTime.Now;

        [MaxLength(15)]
        public string Telefone { get; set; }

        [MaxLength(255)]
        public string Endereco { get; set; }

        [MaxLength(10)]
        public string Genero { get; set; }

        [MaxLength(10)]
        public string Status { get; set; } = "Ativo";

        [MaxLength(50)]
        public string Roles { get; set; } = "Cliente";

        [MaxLength(255)]
        public string TokenVerificacao { get; set; }

        public DateTime? DataExpiracaoToken { get; set; }
    }
}
