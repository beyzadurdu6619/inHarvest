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
    public class ImageManager : IImageService
    {
        private readonly IImageDal _ImageDal;

        public ImageManager(IImageDal ImageDal)
        {
            _ImageDal = ImageDal;
        }

        public List<Image> GetAllList()
        {
            return _ImageDal.GetAllList();
        }

        public Image GetById(int id)
        {
            return _ImageDal.GetById(id);
        }

        public void Insert(Image Image)
        {
            _ImageDal.Insert(Image);
        }

        public void Update(Image Image)
        {
            _ImageDal.Update(Image);
        }

        public void Delete(Image Image)
        {
            _ImageDal.Delete(Image);
        }


    }
}
