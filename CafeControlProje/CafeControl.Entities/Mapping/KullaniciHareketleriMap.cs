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
    public class KullaniciHareketleriMap : EntityTypeConfiguration<KullaniciHareketleri>
    {
        public KullaniciHareketleriMap()
        {

            this.ToTable("KullaniciHareketleri");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(300);


            this.HasRequired(x => x.Kullanicilar).WithMany(x => x.KullaniciHareketleri).HasForeignKey(x => x.KullaniciId); // ilişkilendirmeler 

        }
    }
}
