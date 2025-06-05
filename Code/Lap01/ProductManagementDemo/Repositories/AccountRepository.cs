using BusinessObjects;
using DataAccessObjects;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public AccountMember GetAccountById(string accountId)
            =>AccountDao.GetAccountById(accountId);
    }
}
