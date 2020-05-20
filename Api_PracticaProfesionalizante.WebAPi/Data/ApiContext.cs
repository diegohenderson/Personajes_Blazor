using Api_PracticaProfesionalizante.WebAPi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_PracticaProfesionalizante.WebAPi.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options): base(options)
        {

        }
        public DbSet<Personaje> Personajes { get; set; }
    }
}
