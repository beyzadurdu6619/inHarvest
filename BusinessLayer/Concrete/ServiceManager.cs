using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServicesService
    {
        private readonly IServicesDal _ServicesDal;

        public ServiceManager(IServicesDal ServicesDal)
        {
            _ServicesDal = ServicesDal;
        }

        public List<Services> GetAllList()
        {
            return _ServicesDal.GetAllList();
        }

        public Services GetById(int id)
        {
            return _ServicesDal.GetById(id);
        }

        public void Insert(Services Services)
        {
            _ServicesDal.Insert(Services);
        }

        public void Update(Services Services)
        {
            _ServicesDal.Update(Services);
        }

        public void Delete(Services Services)
        {
            _ServicesDal.Delete(Services);
        }


    }
}
