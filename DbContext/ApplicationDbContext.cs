using Microsoft.EntityFrameworkCore;
using PatientCRUD.Entities;
using PatientCRUD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientCRUD.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=E:\Test\PatientCRUD\PatientCRUD\DB\PatientDB.db");
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientsAddresses> PatientsAddresses { get; set; }

    }
}
