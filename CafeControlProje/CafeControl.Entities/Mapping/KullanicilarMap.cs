using CafeControl.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeControl.Entities.Mapping
{
    public class KullanicilarMap : EntityTypeConfiguration<Kullanicilar>
    {
        public KullanicilarMap()
        {
            this.ToTable("Kullanicilar");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Adres).HasColumnType("varchar").HasMaxLength(500);
            this.Property(p => p.AdSoyad).HasColumnType("varchar").HasMaxLength(150);
            this.Property(p => p.Telefon).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.Email).HasColumnType("varchar").HasMaxLength(150);
            this.Property(p => p.Gorevi).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.KullanıcıAdi).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.Parola).HasColumnType("varchar").HasMaxLength(20);
            this.Property(p => p.HatirlatmaSorusu).HasColumnType("varchar").HasMaxLength(150);
            this.Property(p => p.Cevap).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(300);

        }
    }
}
