using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;

namespace Assignment_1 {
    public class BankAccount {

        private readonly int accountNumber;
        private double balance;
        private string firstName, lastName, address, phoneNumber, email;
        private List<Transaction> statement;

        public BankAccount(int accountNumber, double balance, string firstName, string lastName,
                           string address, string phoneNumber, string email, AccountType type) {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
            statement = new List<Transaction>();
            if (type == AccountType.New) {
                statement.Add(new Transaction(DateTime.Now, "Opening Balance", 0, 0, balance));
                statement.Add(new Transaction(DateTime.Now, "Closing Balance", 0, 0, balance));
            }
        }

        // Deposits the specified amount to the account, and also updates the statement and file.
        public void Deposit(double amount) {
            balance += amount;
            UpdateStatement(amount, TransactionType.Deposit);
            UpdateFile();
        }

        // Withdraws the specified amount from the account if balance is greater or equal to that amount,
        // and also updates the statement and file.
        public void Withdraw(double amount) {
            if (balance >= amount) {
                balance -= amount;
                UpdateStatement(amount, TransactionType.Withdrawal);
                UpdateFile();
            }
        }

        // Creates and/or updates the <account_number>.txt file.
        public void UpdateFile() {
            string statementStringBlock = "";
            foreach (Transaction transaction in statement)
                statementStringBlock += transaction.TextFileString();
            File.WriteAllText(string.Format($"{accountNumber}.txt"),
                              string.Format($"{accountNumber}\n{balance:0.00}\n{firstName}\n{lastName}\n" +
                              $"{address}\n{phoneNumber}\n{email}\n{statementStringBlock}"));
        }

        // Updates the account statement.
        public void UpdateStatement(double amount, TransactionType type) {
            statement.RemoveAt(statement.Count - 1);
            if (type == TransactionType.Deposit)
                statement.Add(new Transaction(DateTime.Now, "Deposit", 0, amount, balance));
            else if (type == TransactionType.Withdrawal)
                statement.Add(new Transaction(DateTime.Now, "Withdrawal", amount, 0, balance));
            statement.Add(new Transaction(DateTime.Now, "Closing Balance", 0, 0, balance));
        }

        // Re-adds existing statement to the account.
        public void ReAddExistingStatement() {
            string[] statementArray = File.ReadAllLines($"{accountNumber}.txt").Skip(7).ToArray();
            foreach (string transaction in statementArray) {
                string[] separator = { "," };
                string[] txnInfo = transaction.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                statement.Add(new Transaction(Convert.ToDateTime(txnInfo[0]), txnInfo[1], Convert.ToDouble(txnInfo[2]),
                        Convert.ToDouble(txnInfo[3]), Convert.ToDouble(txnInfo[4])));
            }
        }

        // Sends a specified email based on the option. Reuturns true if email was sent successfully, false otherwise.
        public bool SendEmail(EmailOptions option) {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new NetworkCredential("appdevdotnet31927@gmail.com", "ndvybppwlcvhhtvj");
            client.EnableSsl = true;

            try {
                MailMessage mail = new MailMessage(new MailAddress("appdevdotnet31927@gmail.com", "Simple Bank"),
                                                   new MailAddress(email));
                mail.IsBodyHtml = true;

                if (option == EmailOptions.AccountInfo) {
                    mail.Subject = "Welcome to Simple Bank";
                    mail.Body = string.Format($"Dear {firstName},<br><br>" +
                                "Welcome to Simple Bank Management System!<br><br>" +
                                "Your account details are as follow:<br>" +
                                
                                $"Account number: {accountNumber}<br>" +
                                $"First name: {firstName}<br>" +
                                $"Last name: {lastName}<br>" +
                                $"Address: {address}<br>" +
                                $"Phone number: {phoneNumber}<br>" +
                                $"Email: {email}<br><br>" +
                                
                                "Kind regards,<br>" +
                                "The Simple Banking Team");
                }

                else if (option == EmailOptions.Statement) {
                    string statementStringBlock = "";
                    foreach (Transaction transaction in statement)
                        statementStringBlock += transaction.HTMLString();
                    
                    mail.Subject = "Your Account Statement";
                    mail.Body = "<style>" +
                                    "table {border-collapse: collapse; width:1000px;}" +
                                    "td, th {text-align: left; padding: 3px;}" +
                                "</style>" +
                                
                                string.Format($"Dear {firstName},<br><br>") +
                                "Below is your account statement:<br><br>" +
                                
                                "<table>" +
                                    "<tr><th>Date</th><th>Description</th><th>Debit</th>" +
                                    "<th>Credit</th><th>Balance</th></tr>" +
                                    statementStringBlock +
                                "</table><br>" +
                                
                                "Kind regards,<br>" +
                                "The Simple Banking Team";
                }
                
                client.Send(mail);
                return true;
            }
            catch (Exception ex) when (ex is FormatException || ex is SmtpException) {
                return false;
            }
        }

        // Returns true if the account numbers match, false otherwise.
        public bool HasNumber(int accountNumber) {
            return this.accountNumber == accountNumber;
        }

        // Returns true if balance is greater or equal to the specified amount, false otherwise.
        public bool HasSufficientFunds(double amount) {
            return balance >= amount;
        }

        // Prints the account details to console.
        public void PrintAccountDetails() {
            Console.WriteLine(" _____________________________________________________________");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                      ACCOUNT DETAILS                      |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine($" |    Account Number: {accountNumber}".PadRight(61, ' ') + "|");
            Console.WriteLine($" |    Account Balance: ${balance:0.00}".PadRight(61, ' ') + "|");
            Console.WriteLine($" |    First Name: {firstName}".PadRight(61, ' ') + "|");
            Console.WriteLine($" |    Last Name: {lastName}".PadRight(61, ' ') + "|");
            Console.WriteLine($" |    Address: {address}".PadRight(61, ' ') + "|");
            Console.WriteLine($" |    Phone: {phoneNumber}".PadRight(61, ' ') + "|");
            Console.WriteLine($" |    Email: {email}".PadRight(61, ' ') + "|");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine();
        }

        // Prints the account statement to console.
        public void PrintStatement() {
            Console.WriteLine(" Date".PadRight(29, ' ') + "Description".PadRight(24, ' ') + "Debit".PadRight(16, ' ') + 
                              "Credit".PadRight(16, ' ') + "Balance".PadRight(16, ' '));
            Console.WriteLine(" ".PadRight(100, '-'));
            foreach (Transaction transaction in statement)
                Console.WriteLine(" " + transaction);
            Console.WriteLine();
        }
    }
}
