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
    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _AddressDal;

        public AddressManager(IAddressDal AddressDal)
        {
            _AddressDal = AddressDal;
        }

        public List<Address> GetAllList()
        {
            return _AddressDal.GetAllList();
        }

        public Address GetById(int id)
        {
            return _AddressDal.GetById(id);
        }

        public void Insert(Address Address)
        {
            _AddressDal.Insert(Address);
        }

        public void Update(Address Address)
        {
            _AddressDal.Update(Address);
        }

        public void Delete(Address Address)
        {
            _AddressDal.Delete(Address);
        }


    }
}
