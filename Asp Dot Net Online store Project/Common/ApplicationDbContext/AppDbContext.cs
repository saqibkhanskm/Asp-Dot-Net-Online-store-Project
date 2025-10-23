
using Asp_Dot_Net_Online_store_Project.Models.F_UsrModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Asp_Dot_Net_Online_store_Project.Common.ApplicationDbContext
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                var Conn = ConfigurationManager.ConnectionStrings["E_Shopper_Connection"].ConnectionString;
                optionsBuilder.UseSqlServer(Conn);
            }

           
        }
        public DbSet<UserInsertModel> Users { get; set; }
    }

}