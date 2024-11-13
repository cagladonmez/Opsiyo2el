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
	public class AccountManager : IAccountService
	{
		IAccountDal _accountDal;

		public AccountManager(IAccountDal accountDal)
		{
			_accountDal = accountDal;
		}

		public void Add(Account entity)
		{
			_accountDal.Insert(entity);
		}

		public void Delete(Account entity)
		{
			throw new NotImplementedException();
		}

		public Account GetById(int id)
		{
            throw new NotImplementedException();
        }

        public Account GetByUserId(int userId)
        {
            return _accountDal.GetByUserId(userId);	
        }

        public List<Account> GetList()
		{
			throw new NotImplementedException();
		}

		public void Update(Account entity)
		{
			_accountDal.Update(entity);
		}
	}
}
