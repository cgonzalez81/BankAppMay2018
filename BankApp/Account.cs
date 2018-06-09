using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
	enum AccountType
	{
		Checking,
		Savings, 
		CD,
		Loan
	}

	/// <summary>
	/// Bank account
	/// </summary>
	class Account
	{
		private static int lastAccountNumber = 0;

		#region Properties
		/// <summary>
		/// unique account number
		/// </summary>
		public int AccountNumber { get; private set; }
		/// <summary>
		/// email address of the user on the account
		/// </summary>
		public string EmailAddress { get; set; }
		//make balance private so user cant determine it
		public decimal Balance { get; private set; }
		/// <summary>
		/// we change type of account from string to  because it's a choice list, not a collection
		/// </summary>
		public AccountType TypeOfAccount { get; set; }
		public DateTime CreatedDate {get; set; }
		#endregion


		//write our own constructor, constructor is a method
		//constructor's job is to allocate memory, it doesnt give return type
		//constructor naMe same name as class name

		public Account()
		{
			//lastAccountNumber = lastAccountNumber + 1
			//lastAccountNumber += 1;
			//AccountNumber = lastAccountNumber;
			//ctrl K and Ctrl C for multi line comment, ctrl U to uncomment
			//make the comment example shorter with next line
			//lastAccountNumber++; means increment of 1
			//++lastAccountNumber; aLso means increment of 1
			AccountNumber = ++lastAccountNumber;
			CreatedDate = DateTime.UtcNow;
		}
		//we are overloading the same thing to do diff things
		//we're overloading the constructor
		//we use the same name as another method but use diff parameters
		/*public Account(string emailAddress) : this ()
		//"this"= another constr with no parameters
		{
			EmailAddress = emailAddress;
		}

		public Account(string emailAddress, string accountType) : this(emailAddress)
		{
			TypeOfAccount = accountType;
		}*/

		#region Methods


		/// <summary>
		/// deposit into account
		/// </summary>
		/// <param name="amount">explain here what the parameter is about (amount to deposit)</param>
		/// <returns>Updated Balance goes here</returns>
		public decimal Deposit(decimal amount)
	{
		//=+ means add it to itself(Balance = Balance + amount
		Balance += amount;
			return Balance;
	}

		public void Withdraw(decimal amount)
		{
			// this amount is private to this method
			//with void, no return is expected
			Balance -= amount;

		}



		#endregion


	}
}
