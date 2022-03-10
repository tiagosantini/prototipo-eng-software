using System;

namespace PrototipoEngSoftware.Dominio.ContaModule
{
    public class ContaCorrente
    {
        public Cliente Cliente { get; set; }
        public Extrato Extrato { private get; set; }
    }
}
