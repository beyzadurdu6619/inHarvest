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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _AnnouncementDal;

        public AnnouncementManager(IAnnouncementDal AnnouncementDal)
        {
            _AnnouncementDal = AnnouncementDal;
        }

        public List<Announcement> GetAllList()
        {
            return _AnnouncementDal.GetAllList();
        }

        public Announcement GetById(int id)
        {
            return _AnnouncementDal.GetById(id);
        }

        public void Insert(Announcement Announcement)
        {
            _AnnouncementDal.Insert(Announcement);
        }

        public void Update(Announcement Announcement)
        {
            _AnnouncementDal.Update(Announcement);
        }

        public void Delete(Announcement Announcement)
        {
            _AnnouncementDal.Delete(Announcement);
        }


    }
}
