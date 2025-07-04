﻿using BusinessObjects;
using Repositories;

namespace Services;

public class AccountService: IAccountService
{
    private readonly IAccountRepository _accountRepository;
    
    public AccountService(IAccountRepository accountRepository)
    {   
        _accountRepository = accountRepository;
    }
    
    public AccountMember GetAccountById(string accountId) => _accountRepository.GetAccountById(accountId);
}