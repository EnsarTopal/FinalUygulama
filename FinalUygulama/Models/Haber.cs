using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace FinalUygulama.Models
{
    public class Haber
    {
        public long HaberID { get; set; }

        [Required(ErrorMessage = "Lütfen haber başlığını giriniz.")]
        public string HaberBaslik { get; set; }

        [Required(ErrorMessage = "Lütfen haber açıklamasını giriniz.")]
        public string HaberAciklama { get; set; }

        [Required(ErrorMessage = "Lütfen haber detayını doldurunuz.")]
        public string HaberDetay { get; set; }

        public string HaberResimYolu { get; set; }

        [Required(ErrorMessage = "Lütfen kategori alanını doldurunuz.")]
        public string Kategori { get; set; }

        public string HaberTarihi { get; set; }
    }
}
