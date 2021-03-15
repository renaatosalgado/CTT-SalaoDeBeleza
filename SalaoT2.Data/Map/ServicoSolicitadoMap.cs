using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoT2.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaoT2.Data.Map
{
    public class ServicoSolicitadoMap : IEntityTypeConfiguration<ServicoSolicitado>
    {
        public void Configure(EntityTypeBuilder<ServicoSolicitado> builder)
        {
            builder.ToTable("ServicoSolicitado");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();



            builder.HasOne(t => t.Servico)
                         .WithMany(tp => tp.ServicoSolicitados)
                         .HasForeignKey(e => e.ServicoId);

            builder.HasOne(t => t.Funcionario)
                       .WithMany(tp => tp.ServicoSolicitados)
                       .HasForeignKey(e => e.FuncionarioId);

        }
    }
}
