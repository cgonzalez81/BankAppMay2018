using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
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
		public string TypeOfAccount { get; set; }
		public DateTime CreatedDate {get; set; }
		#endregion

		/*public Account()
		{
			//lastAccountNumber += 1;
			//AccountNumber = lastAccountNumber;
			//ctrl K and Ctrl C for multi line comment, ctrl U to uncomment
			//make the comment example shorter with next line
			//lastAccountNumber++; means increment of 1
			//++lastAccountNumber; aLso means increment of 1
			AccountNumber = ++lastAccountNumber;
			CreatedDate = DateTime.UtcNow;
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
