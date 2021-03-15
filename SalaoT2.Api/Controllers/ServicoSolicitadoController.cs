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
    public class ServicoSolicitadoController : ControllerBase
    {
        private readonly ServicoSolicitadoRepositorio repo;

        public ServicoSolicitadoController()
        {
            repo = new ServicoSolicitadoRepositorio();
        }

        [HttpGet("{id}")]
        public ServicoSolicitado Get(Guid id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<ServicoSolicitado> Post([FromBody] ServicoSolicitado servicoSolicitado)
        {
            repo.Incluir(servicoSolicitado);
            return repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<ServicoSolicitado> Put(Guid id, [FromBody] ServicoSolicitado servicoSolicitado)
        {
            if (id.Equals(servicoSolicitado.Id))
                repo.Alterar(servicoSolicitado);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<ServicoSolicitado> Delete(Guid id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
