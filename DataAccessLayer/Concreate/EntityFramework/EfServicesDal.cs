using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.Repository;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.EntityFramework
{
    public class EfServicesDal : GenericRepository<Services>, IServicesDal
    {
    }
}
