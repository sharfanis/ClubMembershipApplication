﻿using ClubMembershipApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Data
{
    public class ClubMembershipDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}ClubMembershipDb.db");
            base.OnConfiguring(optionsBuilder);
        }

       public DbSet<User> Users { get; set; }

        // We can create DB table using our model by using migration . Install EntityCore Tools + SQL lite pkg.
        // the path of the DB is complex it is "C:\Users\Shabih Sh\source\repos\ClubMembershipApplication\packages\Microsoft.EntityFrameworkCore.Tools.3.1.2\tools\net461\any"
    }
}
