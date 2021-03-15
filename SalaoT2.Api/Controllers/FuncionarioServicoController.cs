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
    public class FuncionarioServicoController : ControllerBase
    {
        private readonly FuncionarioServicoRepositorio repo;

        public FuncionarioServicoController()
        {
            repo = new FuncionarioServicoRepositorio();
        }

        [HttpGet("{id}")]
        public FuncionarioServico Get(Guid id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<FuncionarioServico> Post([FromBody] FuncionarioServico funcionarioServico)
        {
            repo.Incluir(funcionarioServico);
            return repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<FuncionarioServico> Put(Guid id, [FromBody] FuncionarioServico funcionarioServico)
        {
            if (id.Equals(funcionarioServico.Id))
                repo.Alterar(funcionarioServico);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<FuncionarioServico> Delete(Guid id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
