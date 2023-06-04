using CafeControl.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeControl.Entities.Models
{
    public class Kullanicilar:IEntity
    {
        public int Id { get; set; }

        public string AdSoyad{ get; set; }

        public string Telefon { get; set; }
        public string Adres { get; set; }

        public string Email{ get; set; }
        public string Gorevi { get; set; }
        public string KullanıcıAdi { get; set; }
        public string Parola { get; set; }
        public string HatirlatmaSorusu { get; set; }

        public string Cevap { get; set; }
        public string Aciklama { get; set; }

        public DateTime KayitTarihi { get; set; }

        public bool AktifMi { get; set; }
        
        public ICollection<KullaniciHareketleri> KullaniciHareketleri { get; set; }
    }
}

