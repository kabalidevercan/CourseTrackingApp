using System.ComponentModel.DataAnnotations;

namespace CourseTrackingApp.Data
{

    public class Ogrenci
    {


        [Key]
        public int OgrenciId { get; set; }

        public string? OgrenciAd { get; set; }
        public string? OgrenciSoyad { get; set; }
        public string? OgrenciEmail { get; set; }

        public string? OgrenciTelefon { get; set; }

    }

}