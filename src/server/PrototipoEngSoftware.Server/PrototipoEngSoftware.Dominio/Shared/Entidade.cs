using System.ComponentModel.DataAnnotations;

namespace PrototipoEngSoftware.Dominio.Shared
{
    public abstract class Entidade
    {
        [Key]
        public int Id { get; set; }
    }
}
