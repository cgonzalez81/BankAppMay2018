using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
	#region Properties
	/// <summary>
	/// Bank account
	/// </summary>
	class Account
	{
		/// <summary>
		/// unique account number
		/// </summary>
		public int AccountNumber { get; set; }
		/// <summary>
		/// email address of the user on the account
		/// </summary>
		public string EmailAddress { get; set; }
		public decimal Balance { get; set; }
		public string TypeOfAccount { get; set; }
		#endregion

	}
}
