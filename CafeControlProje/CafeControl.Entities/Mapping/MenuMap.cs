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
    public class MenuMap:EntityTypeConfiguration<Menu>
    {
        public MenuMap()
        {
            this.ToTable("Menu");
            this.HasKey(p => p.Id); // menü içindeki tüm özelliklere ulaşma
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.MenuAdi).HasColumnType("varchar").HasMaxLength(60);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(300);
            this.Property(p => p.Aciklama).HasColumnName("Description");
        }
    }
}
