﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppMvcBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace AppMvcData.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options)
        {
           
        }

        public  DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);

            // definir uma tamanho de uma propriedade caso esqueça. 
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany((e => e.GetProperties().Where(p => p.ClrType == typeof(string)))))
            {
                //Com erro 
                //property.SetColumnName("varchar(100)");

               //Corrigido. 
               property.SetColumnType("varchar(100)");
            }

            //Não deletar em cascate 
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
