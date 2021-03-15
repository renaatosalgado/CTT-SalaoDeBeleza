using Minha1Conexao.Domain.Interface;
using SalaoT2.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalaoT2.Dominio
{
    public class Agendamento : IEntity
    {
        public Guid Id { get; set; }

        public Guid ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        //public List<ServicoSolicitado> ServicosSolicitados { get; set; }
        public Guid ServicoSolicitadoId { get; set; }
        public virtual ServicoSolicitado ServicoSolicitado { get; set; }
        public DateTime DataAgendamento { get; set; }
        public DateTime DataChegada { get; set; }
        public string Anotacao { get; set; }
        public StatusAgenda Status { get; set; }

    }
}
