using Minha1Conexao.Domain.Interface;
using System;
using System.Collections.Generic;

namespace SalaoT2.Dominio
{
    public class Servico : IEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int MinutosParaExecucao { get; set; }
        public decimal Preco { get; set; }
        public virtual List<ServicoSolicitado> ServicoSolicitados { get; set; }

        public virtual List<FuncionarioServico> FuncionarioServicos { get; set; }

    }
}
