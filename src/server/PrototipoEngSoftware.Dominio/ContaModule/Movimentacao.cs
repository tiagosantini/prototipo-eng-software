using PrototipoEngSoftware.Dominio.Shared;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrototipoEngSoftware.Dominio.ContaModule
{
    [Table("TBMovimentacao")]
    public class Movimentacao : Entidade
    {
        [ForeignKey("Conta")]
        public int ContaId { get; set; }
        public Conta Conta { get; set; }

        [Required]
        public TipoMovimentacao Tipo { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public string Informacoes { get; set; }

        [Required]
        public DateTime Data { get; set; } = DateTime.Now;

        public Movimentacao()
        {
        }
    }
}
