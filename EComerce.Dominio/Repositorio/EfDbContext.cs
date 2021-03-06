﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EComerce.Dominio.Entidades;


namespace EComerce.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        //Mapeamento da Classe Produto
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }

        //aula 6 17:00
    }
}
