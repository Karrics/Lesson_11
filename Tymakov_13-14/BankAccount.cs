using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov_13_14
{
    internal class BankAccount
    {
        private readonly string accountNumber;
        private readonly string accountType;
        private string ownerName;
        private decimal balance;
        private List<BankTransaction> transactions;
        

        // Свойства только для чтения
        public string AccountNumber => accountNumber;
        public string AccountType => accountType;

        // Свойство для чтения и записи держателя банковского счета
        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }

        // Конструктор
        public BankAccount(string accountNumber, string accountType, string ownerName)
        {
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.ownerName = ownerName;
            this.balance = 0;
            this.transactions = new List<BankTransaction>();
        }
        public void Withdraw(decimal amount)
        {
            if (0 <= amount && amount <= balance)
            {
                balance -= amount;
                var transaction = new BankTransaction(DateTime.UtcNow, amount);
                transactions.Add(transaction);
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds");
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                var transaction = new BankTransaction(DateTime.UtcNow, amount);
                transactions.Add(transaction);
            }
        }
        public BankTransaction this[int index]
        {
            get
            {
                if (index >= 0 && index < transactions.Count)
                {
                    return transactions[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
            }
        }
        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {balance}");
        }
    }
}
