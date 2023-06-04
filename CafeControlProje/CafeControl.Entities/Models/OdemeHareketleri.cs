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
    public class OdemeHareketleri:IEntity
    {
        public int Id { get; set; }

        public string SatisKodu { get; set; }

        public string OdemeTuru { get; set; }
        public decimal Odenen { get; set; }

        public string Aciklama { get; set; }

        public DateTime Tarih { get; set; }
    }
}
