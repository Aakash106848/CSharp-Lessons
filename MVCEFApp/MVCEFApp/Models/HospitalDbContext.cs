using MVCEFApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Data.SqlClient;

namespace MVCEFApp.Models
{
    public class HospitalDbContext:DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient>Patients { get; set; }
        public DbSet<Appoinment>Appoinments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           String conString = @"server=200411LTP2750\SQLEXPRESS;database=HospitalDB1;integrated security=true;Encrypt=false;";
            options.UseSqlServer(conString);
        }
    }
}
