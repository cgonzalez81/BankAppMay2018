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
			Console.WriteLine("************************");
			Console.WriteLine("***Welcome to my bank***");
			//loop after main

			while (true)
			{
				Console.WriteLine("0. Exit");
				Console.WriteLine("1. Create an account");
				Console.WriteLine("2. Deposit");
				Console.WriteLine("3. Withdraw");
				Console.WriteLine("4. Print all accounts");
				Console.WriteLine("5. Print all transactions");
				Console.Write("Please select an option: ");
				var option = Console.ReadLine();
				switch (option)
				{
					case "0":
						Console.WriteLine("Thank you for visiting the Bank!");
						return;
					case "1":
						Console.Write("Email Address: ");
						var emailAddress = Console.ReadLine();

						var accountTypes = Enum.GetNames(typeof(AccountType));
						for (var i = 0; i < accountTypes.Length; i++)
						{
							Console.WriteLine($"{i}. {accountTypes[i]}");
						}
						Console.Write("Account Type: ");
						var accountType = (AccountType)Enum.Parse(typeof(AccountType), Console.ReadLine());

						Console.Write("Initial Deposit: ");
						var amount = Convert.ToDecimal(Console.ReadLine());

						var account = Bank.CreateAccount(emailAddress, accountType, amount);
						Console.WriteLine($"AN: {account.AccountNumber}, " +
							$"Balance: {account.Balance}, " +
							$"AT: {account.TypeOfAccount}, " +
							$"CD: {account.CreatedDate}");

						break;
					case "2":
						PrintAllAccounts();
						Console.Write("Account Number: ");
						var accountNumber = Convert.ToInt32(Console.ReadLine());

						Console.Write("Amount to Deposit: ");
						amount = Convert.ToDecimal(Console.ReadLine());

						Bank.Deposit(accountNumber, amount);
						Console.WriteLine("Deposit completed successfully ");

						break;
					case "3":
						PrintAllAccounts();
						Console.Write("Account Number: ");
						accountNumber = Convert.ToInt32(Console.ReadLine());

						Console.Write("Amount to Deposit: ");
						amount = Convert.ToDecimal(Console.ReadLine());

						Bank.Withdraw(accountNumber, amount);
						Console.WriteLine("Withdrawal completed successfully ");

						break;
					case "4":
						PrintAllAccounts();
						break;
					case "5":
						PrintAllAccounts();
						Console.Write("Account Number: ");
						accountNumber = Convert.ToInt32(Console.ReadLine());
						var transactions = Bank.GetAllAccountsByAccountNumber(accountNumber);
						foreach (var transaction in transactions)
						{
							Console.WriteLine($"{transaction.Description}, {transaction.TransactionAmount}, {transaction.TransactionDate}, {transaction.TypeOfTransaction}");
						}
						break;
					default:
						break;
				}
			}


			#region Change Code
			/*var account = Bank.CreateAccount("test@test.com", AccountType.Savings, 100.05M);
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
			account.TypeOfAccount = "Checking";
			//account.Balance = 100000000;
			//line below will print all info stated
			//$ is to get the intended format, in line format
			//Console.WriteLine($"AN: {account.AccountNumber}, Balance: {account.Balance}, EA: {account.EmailAddress}, TA {account.TypeOfAccount}, CD: {account.CreatedDate}");

			var account2 = Bank.CreateAccount("test2@test.com");
			Console.WriteLine($"AN: {account2.AccountNumber}, " +
				$"Balance: {account2.Balance}, " +
				$"EA: {account2.EmailAddress}, " +
				$"TA {account2.TypeOfAccount}, " +
				$"CD: {account2.CreatedDate}");

			var account3 = Bank.CreateAccount("test3@test.com");
			Console.WriteLine($"AN: {account3.AccountNumber}, " +
				$"Balance: {account3.Balance}, " +
				$"EA: {account3.EmailAddress}, " +
				$"TA {account3.TypeOfAccount}, " +
				$"CD: {account3.CreatedDate}");*/
			#endregion

		}

		private static void PrintAllAccounts()
		{
			string emailAddress;
			Console.Write("Email Address: ");
			//we removed the "var", because we're not reclaiming it, but reusing it
			emailAddress = Console.ReadLine();

			var accounts = Bank.GetAllAccountsByEmailAddress(emailAddress);
			foreach (var acct in accounts)
			{
				Console.WriteLine($"AN: {acct.AccountNumber}, " +
				$"Balance: {acct.Balance}, " +
				$"AT: {acct.TypeOfAccount}, " +
				$"CD: {acct.CreatedDate}");
			}

			return emailAddress;
		}
	}
}
