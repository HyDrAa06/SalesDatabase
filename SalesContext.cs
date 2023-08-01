using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeFirst.Data.Models;

namespace Sales_Database.Database
{
    public class SalesContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)

        {

            if (!builder.IsConfigured)

                builder.UseSqlServer(Configuration.ConnectionString);

        }
    }
}
