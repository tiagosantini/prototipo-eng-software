using PrototipoEngSoftware.Dominio.Shared;
using System;

namespace PrototipoEngSoftware.Dominio.ContaModule
{
    public class ContaCorrente : Entidade
    {
        public Cliente Cliente { get; set; }
        public Extrato Extrato { get; private set; }
    }
}
