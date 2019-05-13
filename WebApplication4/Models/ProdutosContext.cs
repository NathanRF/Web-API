using Microsoft.EntityFrameworkCore;
using System;
using WebApplication4.Models;

namespace WebApplication4
{
    public class ProdutosContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                new System.Data.SqlClient.SqlConnectionStringBuilder()
                {
                    DataSource = "NATHANSE-LAPTOP",
                    InitialCatalog = "Produtos",
                    UserID = "sa",
                    Password = "12345"
                }.ConnectionString

                );            
        }
    }
}