using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoT2.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaoT2.Data.Map
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Logradouro).HasColumnType("varchar(150)").IsRequired();
            builder.Property(x => x.CEP).HasColumnType("varchar(8)").IsRequired();
            builder.Property(x => x.Bairro).HasColumnType("varchar(100)");
            builder.Property(x => x.Cidade).HasColumnType("varchar(100)");
            builder.Property(x => x.UF).HasColumnType("varchar(2)");
            builder.Property(x => x.Numero).HasColumnType("varchar(20)");
            builder.Property(x => x.Complemento).HasColumnType("varchar(20)");
        }
    }
}
