using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoT2.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaoT2.Data.Map
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Matricula).HasColumnType("varchar(15)").IsRequired();
            builder.Property(x => x.Nome).HasColumnType("varchar(150)").IsRequired();
            builder.Property(x => x.Telefone).HasColumnType("varchar(15)");


            builder.HasOne(t => t.Endereco)
                         .WithMany(tp => tp.Funcionarios)
                         .HasForeignKey(e => e.EnderecoId);

            builder.HasOne(t => t.Turno)
                      .WithMany(tp => tp.Funcionarios)
                      .HasForeignKey(e => e.TurnoId);
            

        }
    }
}
