using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov_13_14
{
    internal class BankTransaction
    {
        private readonly DateTime transactionDate;
        private readonly decimal amount;

        // Свойства только для чтения
        public DateTime TransactionDate => transactionDate;
        public decimal Amount => amount;

        public DateTime UtcNow { get; }
        public object Deposit { get; }

        // Конструктор
        public BankTransaction(DateTime transactionDate, decimal amount)
        {
            this.transactionDate = transactionDate;
            this.amount = amount;
        }

        public BankTransaction(DateTime utcNow, object deposit, decimal amount)
        {
            UtcNow = utcNow;
            Deposit = deposit;
            this.amount = amount;
        }
    }
}
