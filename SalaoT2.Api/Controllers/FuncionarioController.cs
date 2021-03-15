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
    public class FuncionarioController : ControllerBase
    {
        private readonly FuncionarioRepositorio repo;

        public FuncionarioController()
        {
            repo = new FuncionarioRepositorio();
        }

        [HttpGet("{id}")]
        public Funcionario Get(Guid id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Funcionario> Post([FromBody] Funcionario funcionario)
        {
            repo.Incluir(funcionario);
            return repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Funcionario> Put(Guid id, [FromBody] Funcionario funcionario)
        {
            if (id.Equals(funcionario.Id))
                repo.Alterar(funcionario);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Funcionario> Delete(Guid id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
