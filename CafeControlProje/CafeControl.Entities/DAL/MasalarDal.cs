using CafeControl.Entities.Models;
using CafeControl.Entities.Repository;
using CafeControl.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeControl.Entities.DAL
{
    public class MasalarDal: EntityRepositoryBase<CafeContext, Masalar,MasaHareketleriValidator>
    {
        public object MasalariListele(CafeContext context)
        {
            var model = (from masa in context.Masalar join k in context.Kullanicilar.DefaultIfEmpty() on masa.KullaniciId equals k.Id // iki tabloyu birbirine bağlama
                select new 
                {
                    masa.Aciklama,
                    masa.Durumu,
                    masa.EklemeTarihi,
                    masa.Id,
                    masa.IslemType,
                    masa.MasaAdi,
                    masa.RezerveMi,
                    masa.SonIslemTarihi,
                    Kullanici=k.KullanıcıAdi

                }).ToList();
            return model;
        }
    }
}
