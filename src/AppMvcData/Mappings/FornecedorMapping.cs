using System;
using System.Collections.Generic;
using System.Text;
using AppMvcBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppMvcData.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
        {
            public void Configure(EntityTypeBuilder<Fornecedor> builder)
            {
                builder.ToTable("Fornecedores");

                builder.HasKey(p => p.Id);

                builder.Property(p => p.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                builder.Property(p => p.Documento)
                    .IsRequired()
                    .HasColumnType("varchar(14)");

                builder.HasOne(f => f.Endereco) // 1 : 1 => Fornecedor : Endereço 
                    .WithOne(e => e.Fornecedor);

                builder.HasMany(f => f.Produtos) // 1 : n  => Fornecedor : Produtos
                    .WithOne(p => p.Fornecedor)
                    .HasForeignKey(p => p.FornecedorId);

            }
        }

}
