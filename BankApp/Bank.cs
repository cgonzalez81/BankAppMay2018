using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
	static class Bank
	{
		private static List<Account> accounts = new List<Account>();
		private static List<Transaction> transactions = new List<Transaction>();

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
			accounts.Add(account);
			return account;
		}

		public static IEnumerable<Transaction>
	GetAllAccountsByAccountNumber(int accountNumber)
		{
			return transactions.Where(t => t.AccountNumber == accountNumber).OrderByDescending(t => t.TransactionDate);

		}

		//form of a collection
		public static IEnumerable<Account> 
			GetAllAccountsByEmailAddress(string emailAddress)
		{
			//compare the EA of user input with the EA on file
			//learn about Linq and Lambda & ienumberable vs list
			return accounts.Where(a => a.EmailAddress == emailAddress);
	
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
			transactions.Add(transaction);
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
			transactions.Add(transaction);

		}

		private static Account GetAccountByAccountNumber(int accountNumber)
		{
			var account = accounts.Where(a => a.AccountNumber == accountNumber).FirstOrDefault();
			if (account == null)
				return null;

			return account;
		}

	}
}
