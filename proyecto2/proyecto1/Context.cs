using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{

    public DbSet<Notas> Notas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NFDMETJ;Database=parcial3;Trusted_Connection=True; TrustServerCertificate=True; Integrated Security=True");
        }
    }
}