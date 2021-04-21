using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MyPortpolioWeb.Models;

namespace MyPortpolioWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MyPortpolioWeb.Models.Contacts> Contact { get; set; }
        public DbSet<MyPortpolioWeb.Models.Account> Account { get; set; }

       public DbSet<Board> Boards { get; set; }
    }
}
