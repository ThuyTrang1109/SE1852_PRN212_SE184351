﻿using BusinessObjects;

namespace DataAccessObjects
{
    public class AccountDao
    {
        public static AccountMember GetAccountById(string accountId)
        {
            AccountMember accountMember = new AccountMember();
            if (accountId.Equals("PS0001"))
            {
                accountMember.MemberId = accountId;
                accountMember.MemberPassword = "@1";
                accountMember.MemberRole = 1;
            }
            return accountMember;
        }
    }
}