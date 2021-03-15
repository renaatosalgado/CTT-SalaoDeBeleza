using Minha1Conexao.Data.Repository.Base;
using SalaoT2.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaoT2.Data.Repositorio
{
    public class FuncionarioServicoRepositorio : BaseRepositorio<FuncionarioServico>
    {
        public new void Incluir(FuncionarioServico funcionarioServico)
        {
            if ("00000000-0000-0000-0000-000000000000".Equals(funcionarioServico.Id.ToString()))
            {
                funcionarioServico.Id = Guid.NewGuid();
            }
            contexto.Set<FuncionarioServico>().Add(funcionarioServico);
            contexto.SaveChanges();
        }

    }
}
