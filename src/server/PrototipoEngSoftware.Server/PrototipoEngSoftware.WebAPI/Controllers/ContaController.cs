using Microsoft.AspNetCore.Mvc;
using PrototipoEngSoftware.Dominio.ContaModule;
using PrototipoEngSoftware.Dominio.Shared;
using System.Collections.Generic;

namespace PrototipoEngSoftware.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaController : ControllerBase
    {
        private readonly IRepository<Conta> _repository;

        public ContaController(IRepository<Conta> repository)
        {
            _repository = repository;
        }
        
        [HttpPost]
        public ActionResult Create([FromBody] Conta conta)
        {
            bool conseguiuInserir = _repository.Inserir(conta);

            if (!conseguiuInserir)
                return BadRequest();

            return CreatedAtRoute(nameof(GetConta), new { id = conta.Id }, conta);
        }

        [HttpPut("{id:int}")]
        public ActionResult Update(int id, [FromBody] Conta conta)
        {
            if (id != conta.Id)
                return NotFound("O cliente especificado não foi encontrado.");

            bool conseguiuEditar = _repository.Editar(conta);

            if (!conseguiuEditar)
                return StatusCode(500);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete([FromQuery] int id)
        {
            Conta contaEncontrada = _repository.SelecionarPorId(id);

            if (contaEncontrada == null)
                return NotFound("O cliente especificado não foi encontrado.");

            bool conseguiuExcluir = _repository.Excluir(contaEncontrada);

            if (!conseguiuExcluir)
                return StatusCode(500);

            return NoContent();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Conta>> Get()
        {
            IEnumerable<Conta> clientes = _repository.SelecionarTodos();

            return Ok(clientes);
        }

        [HttpGet("{id:int}", Name="GetConta")]
        public ActionResult<Conta> GetConta(int id)
        {
            Conta conta = _repository.SelecionarPorId(id);

            if (conta == null)
                return NotFound("O cliente especificado não foi encontrado.");

            return Ok(conta);
        }
    }
}
