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
    public class EnderecoController : ControllerBase
    {
        private readonly EnderecoRepositorio repo;

        public EnderecoController()
        {
            repo = new EnderecoRepositorio();
        }

        [HttpGet("{id}")]
        public Endereco Get(Guid id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Endereco> Post([FromBody] Endereco endereco)
        {
            repo.Incluir(endereco);
            return repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Endereco> Put(Guid id, [FromBody] Endereco endereco)
        {
            if (id.Equals(endereco.Id))
                repo.Alterar(endereco);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Endereco> Delete(Guid id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
