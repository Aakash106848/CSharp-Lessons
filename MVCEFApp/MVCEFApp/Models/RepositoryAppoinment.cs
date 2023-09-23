using Microsoft.EntityFrameworkCore;

namespace MVCEFApp.Models
{
    public class RepositoryAppoinment
    {
        public static List<Appoinment> GetAppoinments()
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var List = ctx.Appoinments.ToList();
            return List;
        }
        public static Appoinment GetAppoinmentById(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var appoinment = ctx.Appoinments.Find(id);
            return appoinment;
        }
        public static void AddNewAppoinment(Appoinment appoinments)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Appoinments.Add(appoinments);
            ctx.SaveChanges();
        }
        public static void ModifyAppoinment(Appoinment appoinment)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(appoinment).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemoveAppoinment(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            Appoinment appoinment = ctx.Appoinments.Find(id);
            ctx.Appoinments.Remove(appoinment);
            ctx.SaveChanges();
        }
    }
}
