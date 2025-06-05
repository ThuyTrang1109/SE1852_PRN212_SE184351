using BusinessObjects;
using Repositories;

namespace Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountService _iAccountService;
        public AccountService()
        {
            _iAccountService = new AccountService();
        }
        public AccountMember GetAccountById(string accountId)
        {
            return _iAccountService.GetAccountById(accountId);
        }
    }
}
