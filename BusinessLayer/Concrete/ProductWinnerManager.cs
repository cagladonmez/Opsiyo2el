using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductWinnerManager : IProductWinnerService
    {

        IProductWinnerDal _productWinnerDal;

        public ProductWinnerManager(IProductWinnerDal productWinnerDal)
        {
            _productWinnerDal = productWinnerDal;
        }

        public void Add(ProductWinner entity)
        {
            _productWinnerDal.Insert(entity);
        }

        public void Delete(ProductWinner entity)
        {
            throw new NotImplementedException();
        }

        public ProductWinner GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ProductWinner GetByProducttId(int productId)
        {
            return _productWinnerDal.GetByProducttId(productId);
        }

        public List<ProductWinner> GetList()
        {
           return  _productWinnerDal.GetList();
        }

        public void Update(ProductWinner entity)
        {
            throw new NotImplementedException();
        }
    }
}
