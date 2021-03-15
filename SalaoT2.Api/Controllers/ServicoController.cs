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
    public class ServicoController : ControllerBase
    {
        private readonly ServicoRepositorio repo;

        public ServicoController()
        {
            repo = new ServicoRepositorio();
        }

        [HttpGet("{id}")]
        public Servico Get(Guid id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Servico> Post([FromBody] Servico servico)
        {
            repo.Incluir(servico);
            return repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Servico> Put(Guid id, [FromBody] Servico servico)
        {
            if (id.Equals(servico.Id))
                repo.Alterar(servico);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Servico> Delete(Guid id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
