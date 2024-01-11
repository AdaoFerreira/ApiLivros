using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiLivros.Data;

public class LivroContext : DbContext
{
    public LivroContext(DbContextOptions<LivroContext> options) : base(options)
    {

    }

    public DbSet<Livro> Livros { get; set; } 
}
