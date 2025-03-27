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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _AboutDal;

        public AboutManager(IAboutDal AboutDal)
        {
            _AboutDal = AboutDal;
        }

        public List<About> GetAllList()
        {
            return _AboutDal.GetAllList();
        }

        public About GetById(int id)
        {
            return _AboutDal.GetById(id);
        }

        public void Insert(About About)
        {
            _AboutDal.Insert(About);
        }

        public void Update(About About)
        {
            _AboutDal.Update(About);
        }

        public void Delete(About About)
        {
            _AboutDal.Delete(About);
        }


    }
}
