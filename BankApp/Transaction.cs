using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
	enum TransactionType
	{
		Credit,
		Debit
	}

	class Transaction
	{
		public int TrransactionId { get; set; }
		public DateTime TransactionDate { get; set; }
		public string Description { get; set; }
		public decimal TransactionAmount { get; set; }
		public TransactionType TypeOfTransaction { get; set; }

		public int AccountNumber { get; set; }
	}
}
