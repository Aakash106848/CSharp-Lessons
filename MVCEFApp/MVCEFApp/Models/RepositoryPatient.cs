using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace MVCEFApp.Models
{
    public class RepositoryPatient
    {
        public static List<Patient> GetPatients() 
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var list = ctx.Patients.ToList();
            return list;
        }
        public static Patient GetPatientsById(int id ) 
        {   
            HospitalDbContext ctx = new HospitalDbContext();
            var patient = ctx.Patients.Find(id);
            return patient;
        }
        public static void AddPatient(Patient patient) 
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Patients.Add(patient);
            ctx.SaveChanges();
        }
        public static void UpdatePatient(Patient patient) 
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(patient).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemovePatient(int id) 
        {
            HospitalDbContext ctx = new HospitalDbContext();
            Patient patient = ctx.Patients.Find(id);
            ctx.Patients.Remove(patient);
            ctx.SaveChanges();
        }
    }
}
