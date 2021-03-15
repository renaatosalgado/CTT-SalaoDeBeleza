using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoT2.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaoT2.Data.Map
{
    public class FuncionarioServicoMap : IEntityTypeConfiguration<FuncionarioServico>
    {
        public void Configure(EntityTypeBuilder<FuncionarioServico> builder)
        {
            builder.ToTable("FuncionarioServico");


            builder.HasKey(x => new { x.FuncionarioId, x.ServicoId } );

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasOne(t => t.Funcionario)
             .WithMany(tp => tp.FuncionarioServicos)
             .HasForeignKey(i => i.FuncionarioId);

            builder.HasOne(t => t.Servico)
              .WithMany(tp => tp.FuncionarioServicos)
              .HasForeignKey(i => i.ServicoId);

        }
    }
}
