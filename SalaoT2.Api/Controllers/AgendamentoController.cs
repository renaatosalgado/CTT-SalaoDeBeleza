using Microsoft.AspNetCore.Mvc;
using SalaoT2.Data.Repositorio;
using SalaoT2.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalaoT2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        private readonly AgendamentoRepositorio repo;

        public AgendamentoController()
        {
            repo = new AgendamentoRepositorio();
        }

        [HttpGet("{id}")]
        public Agendamento Get(Guid id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Agendamento> Post([FromBody] Agendamento agendamento)
        {
            repo.Incluir(agendamento);
            return repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Agendamento> Put(Guid id, [FromBody] Agendamento agendamento)
        {
            if (id.Equals(agendamento.Id))
                repo.Alterar(agendamento);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Agendamento> Delete(Guid id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
