using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductImageManager : IProductImageDal
    {
        IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }
        public void Delete(ProductImage entity)
        {
            throw new NotImplementedException();
        }


        public List<ProductImage> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(ProductImage entity)
        {
            _productImageDal.Insert(entity);
        }

        public void Update(ProductImage entity)
        {
            throw new NotImplementedException();
        }

        public List<ProductImage> GetImagesById(int id)
        {
            return _productImageDal.GetImagesById(id);
        }
    }
}
