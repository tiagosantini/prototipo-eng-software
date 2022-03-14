using PrototipoEngSoftware.Dominio.Shared;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrototipoEngSoftware.Dominio.ContaModule
{
    [Table("TBConta")]
    public class Conta : Entidade
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public string Senha { get; set; }

        public decimal Saldo { get; set; }

        public IEnumerable<Movimentacao> Movimentacoes { get; private set; }

        public Conta()
        {
        }
    }
}
