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
    public class TurnoController : ControllerBase
    {
        private readonly TurnoRepositorio repo;

        public TurnoController()
        {
            repo = new TurnoRepositorio();
        }

        [HttpGet("{id}")]
        public Turno Get(Guid id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Turno> Post([FromBody] Turno turno)
        {
            repo.Incluir(turno);
            return repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Turno> Put(Guid id, [FromBody] Turno turno)
        {
            if (id.Equals(turno.Id))
                repo.Alterar(turno);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Turno> Delete(Guid id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
