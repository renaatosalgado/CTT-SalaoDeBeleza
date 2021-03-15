using System;
using System.Linq;
using System.Collections.Generic;
using Minha1Conexao.Domain.Interface;
using SalaoT2.Dominio.Enum;

namespace SalaoT2.Dominio
{
    public class FuncionarioServico : IEntity
    {


        public Guid Id { get; set; }
        public Guid FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public Guid ServicoId { get; set; }
        public Servico Servico { get; set; }

    }
}