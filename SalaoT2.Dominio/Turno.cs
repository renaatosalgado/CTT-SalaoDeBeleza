using Minha1Conexao.Domain.Interface;
using SalaoT2.Dominio.Enum;
using System;
using System.Collections.Generic;

namespace SalaoT2.Dominio
{
    public class Turno : IEntity
    {
        public Guid Id { get; set; }
        public TurnoEnum TipoTurno { get; set; }
        public DateTime EntradaSemana{ get; set; }
        public DateTime SaidaSemana { get; set; }
        public DateTime EntradaSabado { get; set; }
        public DateTime SaidaSabado { get; set; }


        public virtual List<Funcionario> Funcionarios { get; set; }
    }
}
