using System;
using System.Linq;
using System.Collections.Generic;
using Minha1Conexao.Domain.Interface;
using SalaoT2.Dominio.Enum;

namespace SalaoT2.Dominio
{
    public class Funcionario : IEntity
    {


        public Guid Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public CargoFunc Cargo { get; set; }

        public Guid TurnoId { get; set; }
        public Turno Turno { get; set; }
        public Guid EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }

        public virtual List<ServicoSolicitado> ServicoSolicitados { get; set; }

        public virtual List<FuncionarioServico> FuncionarioServicos { get; set; }

    }
}
