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
			var account = Bank.CreateAccount("test@test.com", AccountType.Savings, 100.05M);
			Console.WriteLine($"AN: { account.AccountNumber}, " +
				$"Balance: { account.Balance}, " +
				$"EA: {account.EmailAddress}, " +
				$"TA: {account.TypeOfAccount}, " +
				$"CD: {account.CreatedDate}");

			#region Comments
			/*this class is from the user standpoint
			//static refers to a shared memory instance
			//variable is memory allocation, static is created as variable instead of property
			//object, instance of a class, instantiation
			//read from right to left
			//account is the name for the memory, 
			//wccount = new Account
			The above is replaced with the bank section
			{
				EmailAddress = "test@test.com",
				TypeOfAccount = "Checking",
			};
			//account.AccountNumber = 12345;
			//customer should only be able to tell u email and type,not acct # & balance
			account.EmailAddress = "test@test.com";
			account.TypeOfAccount = "Checking";*/
			//account.Balance = 100000000;
			//line below will print all info stated
			//$ is to get the intended format, in line format
			//Console.WriteLine($"AN: {account.AccountNumber}, Balance: {account.Balance}, EA: {account.EmailAddress}, TA {account.TypeOfAccount}, CD: {account.CreatedDate}");

			#endregion

			var account2 = Bank.CreateAccount("test2@test.com");
			Console.WriteLine($"AN: {account2.AccountNumber}, Balance: {account2.Balance}, EA: {account2.EmailAddress}, TA {account2.TypeOfAccount}, CD: {account2.CreatedDate}");

			var account3 = Bank.CreateAccount("test3@test.com");
			Console.WriteLine($"AN: {account3.AccountNumber}, Balance: {account3.Balance}, EA: {account3.EmailAddress}, TA {account3.TypeOfAccount}, CD: {account3.CreatedDate}");

		}
	}
}
