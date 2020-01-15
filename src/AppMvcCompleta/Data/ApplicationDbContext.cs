using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppMvcCompleta.ViewModels;

namespace AppMvcCompleta.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        public DbSet<AppMvcCompleta.ViewModels.ProdutoViewModel> ProdutoViewModel { get; set; }

        //public DbSet<AppMvcCompleta.ViewModels.FornecedorViewModel> FornecedorViewModel { get; set; }
    }

    
}
