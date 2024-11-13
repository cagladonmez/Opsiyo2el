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
	public class SubCategoryManager : ISubCategoryService
	{
		ISubCategoryDal _subcategoryDal;

		public SubCategoryManager(ISubCategoryDal subcategoryDal)
		{
			_subcategoryDal = subcategoryDal;
		}

		public void Add(SubCategory entity)
		{
            _subcategoryDal.Insert(entity);

        }

		public void Delete(SubCategory entity)
		{
            _subcategoryDal.Delete(entity);
        }

		public SubCategory GetById(int id)
		{
			return _subcategoryDal.GetById(id);
		}

		public List<SubCategory> GetList()
		{
			return _subcategoryDal.GetList();
		}

		public List<SubCategory> GetSubCategories(int parentId)
		{
			return _subcategoryDal.GetSubCategories(parentId);
		}

		public void Update(SubCategory entity)
		{
			throw new NotImplementedException();
		}
	}
}
