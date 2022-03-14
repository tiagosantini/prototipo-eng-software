using Microsoft.EntityFrameworkCore;
using PrototipoEngSoftware.Dominio.ContaModule;
using PrototipoEngSoftware.Dominio.Shared;
using System.Collections.Generic;
using System.Linq;

namespace PrototipoEngSoftware.Infra.EntityFramework.Repositories
{
    public class ContaRepository : IRepository<Conta>
    {
        private readonly ContaContext _contaContext;

        public ContaRepository(ContaContext context)
        {
            _contaContext = context;
        }

        public bool Inserir(Conta entidade)
        {
            _contaContext.Contas.Add(entidade);

            if (_contaContext.SaveChanges() < 1)
                return false;

            return true;
        }

        public bool Editar(Conta entidade)
        {
            _contaContext.Entry(entidade).State = EntityState.Modified;

            if (_contaContext.SaveChanges() < 1)
                return false;

            return true;
        }

        public bool Excluir(Conta entidade)
        {
            _contaContext.Contas.Remove(entidade);

            if (_contaContext.SaveChanges() < 1)
                return false;

            return true;
        }

        public Conta SelecionarPorId(int id)
        {
            return _contaContext.Contas.Find(id);
        }

        public ICollection<Conta> SelecionarTodos()
        {
            return _contaContext.Contas.ToList();
        }

        public bool Existe(int id)
        {
            return _contaContext.Contas.Any(c => c.Id == id);
        }
    }
}
