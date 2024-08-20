using Microsoft.EntityFrameworkCore;

namespace CourseTrackingApp.Data
{

    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options): base(options){

        }

        public DbSet<Kurs> Kurslar => Set<Kurs>();

        public DbSet<Ogrenci> Ogrenciler => Set<Ogrenci>();

        public DbSet<KursKayit> KursKayitlar => Set<KursKayit>();

    }


}