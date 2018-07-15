using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
	static class Bank
	{

		private static BankModel db = new BankModel();

		public static Account CreateAccount(string emailAddress,
			AccountType typeOfAccount= AccountType.Checking, 
			decimal initialAmount = 0.0M)
		{
			//this is a factory example
			var account = new Account
			{
				EmailAddress = emailAddress,
				TypeOfAccount = typeOfAccount
			};
			if (initialAmount > 0)
			{
				account.Deposit(initialAmount);
			}
	
			db.Accounts.Add(account);
			db.SaveChanges();
			return account;
		}

		public static IEnumerable<Transaction>
	GetAllAccountsByAccountNumber(int accountNumber)
		{
			return db.Transactions.Where(t => t.AccountNumber == accountNumber).OrderByDescending(t => t.TransactionDate);

		}

		//form of a collection
		public static IEnumerable<Account> 
			GetAllAccountsByEmailAddress(string emailAddress)
		{
			//compare the EA of user input with the EA on file
			//learn about Linq and Lambda & ienumberable vs list
			return db.Accounts.Where(a => a.EmailAddress == emailAddress);
	
		}

		public static void Deposit(int accountNumber, decimal amount)
		{
			var account = GetAccountByAccountNumber(accountNumber);
			account.Deposit(amount);
			var transaction = new Transaction
			{
				TransactionDate = DateTime.UtcNow,
				Description = "Deposit made in the branch",
				TransactionAmount = amount,
				AccountNumber = accountNumber,
				TypeOfTransaction = TransactionType.Credit
			};
			db.Transactions.Add(transaction);
			db.SaveChanges();
		}

		public static void Withdraw(int accountNumber, decimal amount)
		{
			var account = GetAccountByAccountNumber(accountNumber);
			account.Withdraw(amount);

			var transaction = new Transaction
			{
				TransactionDate = DateTime.UtcNow,
				Description = "Withdrawal made in the branch",
				TransactionAmount = amount,
				AccountNumber = accountNumber,
				TypeOfTransaction = TransactionType.Debit
			};
			db.Transactions.Add(transaction);
			db.SaveChanges();
		}

		private static Account GetAccountByAccountNumber(int accountNumber)
		{
			var account = db.Accounts.Where(a => a.AccountNumber == accountNumber).FirstOrDefault();
			if (account == null)
				return null;

			return account;
		}

	}
}
