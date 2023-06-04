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
    public class MasaHareketleriDal: EntityRepositoryBase<CafeContext, MasaHareketleri,MasaHareketleriValidator>
    {
    }
}
