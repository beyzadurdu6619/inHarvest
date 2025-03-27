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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _ContactDal;

        public ContactManager(IContactDal ContactDal)
        {
            _ContactDal = ContactDal;
        }

        public List<Contact> GetAllList()
        {
            return _ContactDal.GetAllList();
        }

        public Contact GetById(int id)
        {
            return _ContactDal.GetById(id);
        }

        public void Insert(Contact Contact)
        {
            _ContactDal.Insert(Contact);
        }

        public void Update(Contact Contact)
        {
            _ContactDal.Update(Contact);
        }

        public void Delete(Contact Contact)
        {
            _ContactDal.Delete(Contact);
        }


    }
}

