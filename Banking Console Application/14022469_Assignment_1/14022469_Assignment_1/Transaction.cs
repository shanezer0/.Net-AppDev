using System;

namespace _14022469_Assignment_1


{
    public class Transaction
    {

        private DateTime dateTime;
        private string Description;
        private double debit, credit, balance;

        public Transaction(DateTime dateTime, string description, double debit, double credit, double balance)
        {
            this.dateTime = dateTime;
            this.Description = description;
            this.debit = debit;
            this.credit = credit;
            this.balance = balance;
        }

       
        public string TextFileString()
        {
            return string.Format($"{dateTime.ToString("dd/MM/yyyy  hh:mm tt")}," +
                                 $"{Description},{debit},{credit},{balance}\n");
        }

        
        public string HTMLString()
        {
            return string.Format($"<tr><td>{dateTime.ToString("dd/MM/yyyy  hh:mm tt")}</td>" +
                                 $"<td>{Description}</td><td>{debit:0.00}</td><td>{credit:0.00}</td>" +
                                 $"<td>{balance:0.00}</td></tr>");
        }

       
        public override string ToString()
        {
            return dateTime.ToString("dd/MM/yyyy  hh:mm tt").PadRight(28, ' ') +
                   Description.PadRight(24, ' ') +
                   string.Format($"{debit:0.00}").PadRight(16, ' ') +
                   string.Format($"{credit:0.00}").PadRight(16, ' ') +
                   string.Format($"{balance:0.00}").PadRight(16, ' ');
        }
    }
}