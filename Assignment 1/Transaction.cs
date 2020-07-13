using System;

namespace Assignment_1 {
    public class Transaction {

        private DateTime dateTime;
        private string description;
        private double debit, credit, balance;

        public Transaction(DateTime dateTime, string description, double debit, double credit, double balance) {
            this.dateTime = dateTime;
            this.description = description;
            this.debit = debit;
            this.credit = credit;
            this.balance = balance;
        }

        // Formats the transaction for text file output.
        public string TextFileString() {
            return string.Format($"{dateTime.ToString("dd/MM/yyyy  hh:mm tt")}," +
                                 $"{description},{debit},{credit},{balance}\n");
        }

        // Formats the transaction for email output.
        public string HTMLString() {
            return string.Format($"<tr><td>{dateTime.ToString("dd/MM/yyyy  hh:mm tt")}</td>" +
                                 $"<td>{description}</td><td>{debit:0.00}</td><td>{credit:0.00}</td>" +
                                 $"<td>{balance:0.00}</td></tr>");
        }

        // Formats the transaction for console output.
        public override string ToString() {
            return dateTime.ToString("dd/MM/yyyy  hh:mm tt").PadRight(28, ' ') +
                   description.PadRight(24, ' ') +
                   string.Format($"{debit:0.00}").PadRight(16, ' ') +
                   string.Format($"{credit:0.00}").PadRight(16, ' ') +
                   string.Format($"{balance:0.00}").PadRight(16, ' ');
        }
    }
}
