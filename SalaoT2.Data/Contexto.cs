using Microsoft.EntityFrameworkCore;
using SalaoT2.Data.Map;
using SalaoT2.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minha1Conexao.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<ServicoSolicitado> ServicoSolicitado { get; set; }
        public DbSet<Agendamento> Agendamento { get; set; }
        public DbSet<FuncionarioServico> FuncionarioServico { get; set; }
        public DbSet<Turno> Turno { get; set; }

        




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Salao;User Id=sa;Password=;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
            modelBuilder.ApplyConfiguration(new ServicoMap());
            modelBuilder.ApplyConfiguration(new ServicoSolicitadoMap());
            modelBuilder.ApplyConfiguration(new AgendamentoMap());
            modelBuilder.ApplyConfiguration(new FuncionarioServicoMap());
            modelBuilder.ApplyConfiguration(new TurnoMap());

            
            base.OnModelCreating(modelBuilder);
        }
    }
}
