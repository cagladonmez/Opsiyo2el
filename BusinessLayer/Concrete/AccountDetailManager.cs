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
	public class AccountDetailManager : IAccountDetailService
	{
		IAccountDetailDal _accountdetailDal;

		public AccountDetailManager(IAccountDetailDal accountdetailDal)
		{
			_accountdetailDal = accountdetailDal;
		}

		public void Add(AccountDetail entity)
		{
			_accountdetailDal.Insert(entity);	
		}

		public void Delete(AccountDetail entity)
		{
			throw new NotImplementedException();
		}

        public List<AccountDetail> GetAccountDetails(int accountId)
        {
            return _accountdetailDal.GetAccountDetails(accountId);	
        }

        public AccountDetail GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<AccountDetail> GetList()
		{
			throw new NotImplementedException();
		}

		public void Update(AccountDetail entity)
		{
			_accountdetailDal.Update(entity);
		}
	}
}
