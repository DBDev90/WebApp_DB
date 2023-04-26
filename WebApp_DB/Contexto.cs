﻿using Microsoft.EntityFrameworkCore;
using WebApp_DB.Entidades;

namespace WebApp_DB
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt)
        {

        }

        public DbSet<Produto> Produto { get; set; }
    }
}