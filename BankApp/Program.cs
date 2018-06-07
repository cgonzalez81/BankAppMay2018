using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
	class Program
	{
		//when it has closed parenth. it is a method
		//only one main method for every project
		static void Main(string[] args)
		{
			//object, instance of a class, instantiation
			//read from right to left
			//account is the name for the memory, 
			//when we name it acct, it knows where to go
			var account = new Account();
			//account.AccountNumber = 12345;
			//customer should only be able to tell u email and type,not acct # & balance
			account.EmailAddress = "test@test.com";
			account.TypeOfAccount = "Checking";
			//account.Balance = 100000000;

			Console.WriteLine($"AN: {account.AccountNumber}, Balance {account.Balance}, EA {account.EmailAddress}");

			var account2 = new Account();
			account2.EmailAddress = "test2@test.com";

			Console.WriteLine(account2.Balance);
		}
	}
}
