using Minha1Conexao.Domain.Interface;
using SalaoT2.Dominio.Enum;
using System;
using System.Collections.Generic;

namespace SalaoT2.Dominio
{
    public class ServicoSolicitado : IEntity
    {
        public Guid Id { get; set; }
        public Guid ServicoId { get; set; }
        public Servico Servico { get; set; }
        public Guid FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public StatusServico Status { get; set; }
        public DateTime DataServico { get; set; }
        public Decimal Preco { get; set; }

        public virtual List<Agendamento> Agendamentos { get; set; }

    }


}
