﻿using HsrTech.Domain.Entities;
using HsrTech.Domain.Interface.Repository;
using HsrTech.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HsrTech.Domain.Entities.Partial;

namespace HsrTech.Domain.Service
{
    public class BankAccountService : ServiceBase<BankAccount>, IBankAccountService
    {
        private readonly IBankAccountRepository _bankAccountRepository;
        public BankAccountService(IBankAccountRepository bankAccountRepository) : base(bankAccountRepository)
        {
            _bankAccountRepository = bankAccountRepository;
        }

        public void CreateAccount(decimal balance, int limit, string login)
        {
            _bankAccountRepository.CreateAccount(balance, limit, login);
        }

        public BankAccount GetAccountByNumberAccount(int numberAccount)
        {
            return _bankAccountRepository.GetAccountByNumberAccount(numberAccount);
        }

        public IList<BankAccount> ListAccountsByLogin(string login)
        {
            return _bankAccountRepository.ListAccountsByLogin(login);
        }

        public bool Transfer(decimal value, int numberAccount, int typeTransfer, string login, int userNumberAccount)
        {
            return _bankAccountRepository.Transfer(value, numberAccount, typeTransfer, login, userNumberAccount);
        }

        public IList<AccountCreation> GetAccountsCreated(DateTime? startDate, DateTime? endDate, int type)
        {
            return _bankAccountRepository.GetAccountsCreated(startDate, endDate, type);
        }
    }
}
