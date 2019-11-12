﻿using AluguelCarro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarro.Mapeamento
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(e => e.Rua).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Numero).IsRequired();
            builder.Property(e => e.Bairro).IsRequired();
            builder.Property(e => e.Cidade).IsRequired();
            builder.Property(e => e.Estado).IsRequired();

            builder.HasOne(e => e.Usuario).WithMany(e => e.Enderecos).HasForeignKey(e => e.UsuarioId);

            builder.ToTable("Enderecos");
        }
    }
}
