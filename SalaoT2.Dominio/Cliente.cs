using Minha1Conexao.Domain.Interface;
using System;
using System.Collections.Generic;

namespace SalaoT2.Dominio
{
    public class Cliente : IEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }

        public virtual List<Agendamento> Agendamentos { get; set; }

    }
}
