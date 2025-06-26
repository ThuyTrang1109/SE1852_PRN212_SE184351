using BusinessObjects;

namespace DataAccessObjects;

public class AccountDAO
{
    private static AccountDAO _instance;
    
    public AccountDAO() {}

    public static AccountDAO Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new AccountDAO();
            }
            return _instance;
        }
    }
    public AccountMember GetAccountById(string accountId)
    {
        AccountMember account = new AccountMember();
        if (accountId.Equals("PS0001"))
        {
            account.MemberId = accountId;
            account.MemberPassword = "@1";
            account.MemberRole = 1;
        }
        return account;
    }
}