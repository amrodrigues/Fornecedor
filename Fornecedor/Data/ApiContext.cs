using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using Fornecedor.Model;
namespace Fornecedor.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public DbSet<Fornecedores> Fornecedores { get; set; }

    }
}
