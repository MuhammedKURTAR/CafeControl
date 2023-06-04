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
    public class OdemeHareketleriMap: EntityTypeConfiguration<OdemeHareketleri>
    {
        public OdemeHareketleriMap()
        {
            this.ToTable("OdemeHareketleri");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SatisKodu).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.OdemeTuru).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(300);

        }
    }
}
