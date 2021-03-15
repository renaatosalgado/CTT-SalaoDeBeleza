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
    public class ClienteController : ControllerBase
    {
        private readonly ClienteRepositorio repo;

        public ClienteController()
        {
            repo = new ClienteRepositorio();
        }

        [HttpGet("{id}")]
        public Cliente Get(Guid id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Cliente> Post([FromBody] Cliente cliente)
        {
            repo.Incluir(cliente);
            return repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Cliente> Put(Guid id, [FromBody] Cliente cliente)
        {
            if (id.Equals(cliente.Id))
                repo.Alterar(cliente);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Cliente> Delete(Guid id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
