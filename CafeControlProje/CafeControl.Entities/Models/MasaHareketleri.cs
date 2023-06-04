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
    public class MasaHareketleri:IEntity
    {
     
        public int Id { get; set; }
        public string SatisKodu { get; set; }

        public int MasaId { get; set; }

        public int MenuID { get; set; }

        public int UrunId { get; set; }

        public int Miktari { get; set; }
        public decimal BirimFiyati { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; } 
        public Masalar Masalar { get; set; }
    }
}
