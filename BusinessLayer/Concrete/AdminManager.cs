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
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _AdminDal;

        public AdminManager(IAdminDal AdminDal)
        {
            _AdminDal = AdminDal;
        }

        public List<Admin> GetAllList()
        {
            return _AdminDal.GetAllList();
        }

        public Admin GetById(int id)
        {
            return _AdminDal.GetById(id);
        }

        public void Insert(Admin Admin)
        {
            _AdminDal.Insert(Admin);
        }

        public void Update(Admin Admin)
        {
            _AdminDal.Update(Admin);
        }

        public void Delete(Admin Admin)
        {
            _AdminDal.Delete(Admin);
        }


    }
}
