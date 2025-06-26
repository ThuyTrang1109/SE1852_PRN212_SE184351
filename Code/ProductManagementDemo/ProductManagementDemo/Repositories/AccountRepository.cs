using BusinessObjects;
using DataAccessObjects;

namespace Repositories;

public class AccountRepository: IAccountRepository
{
    public AccountMember GetAccountById(string accountId) => AccountDAO.Instance.GetAccountById(accountId);
}