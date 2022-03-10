using PrototipoEngSoftware.Dominio.Shared;

namespace PrototipoEngSoftware.Dominio.ContaModule
{
    public class Cliente : Entidade
    {
        public string CPF { get; set; }
        public string Senha { get; set; }
    }
}
