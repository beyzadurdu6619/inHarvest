using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.EntityFramework;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _SocialMediaDal;

        public SocialMediaManager(ISocialMediaDal SocialMediaDal)
        {
            _SocialMediaDal = SocialMediaDal;
        }

        public List<SocialMedia> GetAllList()
        {
            return _SocialMediaDal.GetAllList();
        }

        public SocialMedia GetById(int id)
        {
            return _SocialMediaDal.GetById(id);
        }

        public void Insert(SocialMedia Address)
        {
            _SocialMediaDal.Insert(Address);
        }

        public void Update(SocialMedia Address)
        {
            _SocialMediaDal.Update(Address);
        }

        public void Delete(SocialMedia Address)
        {
            _SocialMediaDal.Delete(Address);
        }


    }
}
