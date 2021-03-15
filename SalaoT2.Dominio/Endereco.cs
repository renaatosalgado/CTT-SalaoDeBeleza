using Minha1Conexao.Domain.Interface;
using System;
using System.Collections.Generic;

namespace SalaoT2.Dominio
{
    public class Endereco : IEntity
    {
        public Guid Id { get; set; }
        public string Logradouro { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }

        public virtual List<Funcionario> Funcionarios { get; set; }

    }
}
