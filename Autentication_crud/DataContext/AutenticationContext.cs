using Autentication_crud.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autentication_crud.DataContext
{
    public class AutenticationContext:DbContext
    {
        public AutenticationContext(DbContextOptions<AutenticationContext> options) : base(options){ }
        //My Data Models
        public DbSet<UserData> UserData { get; set; }
        public DbSet<UserSecurity> UserSecurity { get; set; }
    }
}
