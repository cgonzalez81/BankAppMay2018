using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
	static class Bank
	{
		public static Account CreateAccount(string emailAddress,
			AccountType typeOfAccount= AccountType.Checking, decimal initialAmount = 0.0M)
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
			return account;
		}
	}
}
