using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Assignment_1 {
    public class BankMgmtSystem {

        private List<BankAccount> accounts;

        public BankMgmtSystem() {
            accounts = new List<BankAccount>();
        }

        public static void Main(string[] args) {
            ConsoleKey choice = 0;
            new BankMgmtSystem().LoginMenu(ref choice);
        }

        // Handles the logic for the login menu.
        private void LoginMenu(ref ConsoleKey choice) {
            Console.Clear();
            PrintLoginMenu();

            Console.SetCursorPosition(16, 7);
            string username = Console.ReadLine();
            Console.SetCursorPosition(16, 8);
            string password = "";
            ConsoleKeyInfo key;
            do {
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Backspace && password.Length > 0) {
                    password = password.Remove(password.Length - 1);
                    Console.Write("\b \b");
                }
                else if (key.Key != ConsoleKey.Spacebar && key.Key != ConsoleKey.Enter &&
                         key.Key != ConsoleKey.Escape && key.Key != ConsoleKey.Tab &&
                         key.Key != ConsoleKey.Backspace && key.KeyChar != '\u0000') {
                    password += key.KeyChar;
                    Console.Write("*");
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.SetCursorPosition(0, 11);

            if (File.Exists("login.txt")) {
                bool loginSuccessful = false;
                string[] loginCredentials = File.ReadAllLines("login.txt");
                try {
                    foreach (string loginCredential in loginCredentials) {
                        string[] separator = { "|", " " };
                        string[] login = loginCredential.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                        if (username == login[0] && password == login[1]) {
                            loginSuccessful = true;
                            choice = ConsoleKey.N;
                            MainMenu();
                            break;
                        }
                    }
                    if (!loginSuccessful) {
                        Console.WriteLine(" Incorrect username or password.");
                        Console.Write(" Retry (Y/N)? ");
                        ReadChoice(ref choice, ref choice, MenuOptions.LoginMenu);
                    }
                }
                catch (IndexOutOfRangeException) {
                    choice = ConsoleKey.N;
                    Console.WriteLine(" Error: login.txt does not contain login credentials in the correct format.\n");
                    Console.Write(" Press any key to exit... ");
                    Console.ReadKey();
                }
            }
            else {
                choice = ConsoleKey.N;
                Console.WriteLine(" Error: login.txt is missing.\n");
                Console.Write(" Press any key to exit... ");
                Console.ReadKey();
            }
        }

        // Handles the logic for the main menu.
        private void MainMenu() {
            ConsoleKey choice = 0;
            ConsoleKey choice1 = 0;
            ConsoleKey choice2 = 0;
            bool lastInputInvalid = false;

            while (choice != ConsoleKey.D7) {
                Console.Clear();
                PrintMainMenu();
                if (lastInputInvalid)
                    Console.WriteLine(" Invalid input. Please enter a number between 1 - 7.");
                lastInputInvalid = false;

                Console.SetCursorPosition(25, 14);
                choice = Console.ReadKey().Key;

                switch (choice) {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        CreateAccount(ref choice1, ref choice2);
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        SearchAccount(ref choice1);
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Deposit(ref choice1);
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Withdraw(ref choice1);
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        ViewStatement(ref choice1);
                        break;

                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        DeleteAccount(ref choice1);
                        break;

                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        break;

                    default:
                        lastInputInvalid = true;
                        break;
                }
            }
        }

        // Handles the logic for the account creation menu.
        private void CreateAccount(ref ConsoleKey choice1, ref ConsoleKey choice2) {
            Console.Clear();
            PrintAccountCreationMenu();

            char[] trimChars = { ' ' };
            Console.SetCursorPosition(18, 7);
            string firstName = Console.ReadLine().Trim(trimChars);
            Console.SetCursorPosition(17, 8);
            string lastName = Console.ReadLine().Trim(trimChars);
            Console.SetCursorPosition(15, 9);
            string address = Console.ReadLine().Trim(trimChars);
            Console.SetCursorPosition(13, 10);
            string phoneNumber = Console.ReadLine().Trim(trimChars);
            Console.SetCursorPosition(13, 11);
            string email = Console.ReadLine().Trim(trimChars);
            Console.SetCursorPosition(0, 14);
            Console.Write(" Are you sure the information is correct (Y/N)? ");

            do {
                choice1 = Console.ReadKey().Key;
                switch (choice1) {

                    case ConsoleKey.Y:
                        Console.WriteLine();
                        if (Int64.TryParse(phoneNumber, out long phoneNumberInt) && phoneNumber.Length == 10) {
                            int accountNumber;
                            do {
                                accountNumber = new Random().Next(100000, 99999999);
                            } while (File.Exists($"{accountNumber}.txt"));
                            BankAccount newAccount = new BankAccount(accountNumber, 0, firstName, lastName,
                                    address, phoneNumber, email, AccountType.New);

                            if (newAccount.SendEmail(EmailOptions.AccountInfo)) {
                                accounts.Add(newAccount);
                                newAccount.UpdateFile();
                                Console.WriteLine(" New account created successfully.");
                                Console.WriteLine(" You will receive an email shortly.");
                                Console.WriteLine($" Account number: {accountNumber}");
                                Console.Write("\n Create another account (Y/N)? ");
                                ReadChoice(ref choice1, ref choice2, MenuOptions.CreateAccount);
                            }

                            else {
                                Console.WriteLine(" Invalid email address.");
                                Console.Write(" Retry (Y/N)? ");
                                ReadChoice(ref choice1, ref choice2, MenuOptions.CreateAccount);
                            }
                        }

                        else {
                            Console.WriteLine(" Invalid phone number.");
                            Console.Write(" Retry (Y/N)? ");
                            ReadChoice(ref choice1, ref choice2, MenuOptions.CreateAccount);
                        }

                        break;

                    case ConsoleKey.N:
                        CreateAccount(ref choice1, ref choice2);
                        break;

                    default:
                        Console.Write("\b \b");
                        break;
                } 
            } while (choice1 != ConsoleKey.Y && choice2 != ConsoleKey.N);
        }

        // Handles the logic for the account search menu.
        private void SearchAccount(ref ConsoleKey choice) {
            Console.Clear();
            PrintMenu(MenuOptions.SearchAccount);

            Console.SetCursorPosition(22, 7);
            string accountNumber = Console.ReadLine();
            Console.SetCursorPosition(0, 10);

            if (AccountExists(accountNumber)) {
                Account(Convert.ToInt32(accountNumber)).PrintAccountDetails();
                Console.Write(" Search another account (Y/N)? ");
                ReadChoice(ref choice, ref choice, MenuOptions.SearchAccount);
            }
            else {
                Console.WriteLine(" Invalid account number.");
                Console.Write(" Retry (Y/N)? ");
                ReadChoice(ref choice, ref choice, MenuOptions.SearchAccount);
            }
        }

        // Handles the logic for the deposit menu.
        private void Deposit(ref ConsoleKey choice) {
            Console.Clear();
            PrintMenu(MenuOptions.Deposit);

            Console.SetCursorPosition(22, 7);
            string accountNumber = Console.ReadLine();

            if (AccountExists(accountNumber)) {
                Console.SetCursorPosition(15, 8);
                string tempAmount = Console.ReadLine();
                Console.SetCursorPosition(0, 11);

                if (Double.TryParse(tempAmount, out double amount)) {
                    Account(Convert.ToInt32(accountNumber)).Deposit(amount);
                    Console.WriteLine(" Deposit successful.");
                    Console.Write("\n Make another deposit (Y/N)? ");
                    ReadChoice(ref choice, ref choice, MenuOptions.Deposit);
                }

                else {
                    Console.WriteLine(" Invalid amount.");
                    Console.Write(" Retry (Y/N)? ");
                    ReadChoice(ref choice, ref choice, MenuOptions.Deposit);
                }
            }

            else {
                Console.SetCursorPosition(0, 11);
                Console.WriteLine(" Invalid account number.");
                Console.Write(" Retry (Y/N)? ");
                ReadChoice(ref choice, ref choice, MenuOptions.Deposit);
            }
        }

        // Handles the logic for the withdraw menu.
        private void Withdraw(ref ConsoleKey choice) {
            Console.Clear();
            PrintMenu(MenuOptions.Withdraw);

            Console.SetCursorPosition(22, 7);
            string accountNumber = Console.ReadLine();

            if (AccountExists(accountNumber)) {
                Console.SetCursorPosition(15, 8);
                string tempAmount = Console.ReadLine();
                Console.SetCursorPosition(0, 11);

                if (Double.TryParse(tempAmount, out double amount)) {

                    if (Account(Convert.ToInt32(accountNumber)).HasSufficientFunds(amount)) {
                        Account(Convert.ToInt32(accountNumber)).Withdraw(amount);
                        Console.WriteLine(" Withdraw successful.");
                        Console.Write("\n Make another withdrawal (Y/N)? ");
                        ReadChoice(ref choice, ref choice, MenuOptions.Withdraw);
                    }

                    else {
                        Console.WriteLine(" Insufficient funds.");
                        Console.Write(" Retry (Y/N)? ");
                        ReadChoice(ref choice, ref choice, MenuOptions.Withdraw);
                    }
                }

                else {
                    Console.WriteLine(" Invalid amount.");
                    Console.Write(" Retry (Y/N)? ");
                    ReadChoice(ref choice, ref choice, MenuOptions.Withdraw);
                }
            }

            else {
                Console.SetCursorPosition(0, 11);
                Console.WriteLine(" Invalid account number.");
                Console.Write(" Retry (Y/N)? ");
                ReadChoice(ref choice, ref choice, MenuOptions.Withdraw);
            }
        }

        // Handles the logic for the view statement menu.
        private void ViewStatement(ref ConsoleKey choice) {
            Console.Clear();
            PrintMenu(MenuOptions.ViewStatement);

            Console.SetCursorPosition(22, 7);
            string accountNumber = Console.ReadLine();
            Console.SetCursorPosition(0, 10);

            if (AccountExists(accountNumber)) {
                Account(Convert.ToInt32(accountNumber)).PrintStatement();
                Console.Write(" Email statement (Y/N)? ");
                ReadChoice(ref choice, ref choice, MenuOptions.ViewStatement, Convert.ToInt32(accountNumber));
                Console.Write("\n View another statement (Y/N)? ");
                ReadChoice(ref choice, ref choice, MenuOptions.ViewStatement2);
            }
            else {
                Console.WriteLine(" Invalid account number.");
                Console.Write(" Retry (Y/N)? ");
                ReadChoice(ref choice, ref choice, MenuOptions.ViewStatement2);
            }
        }

        // Handles the logic for the account deletion menu.
        private void DeleteAccount(ref ConsoleKey choice) {
            Console.Clear();
            PrintMenu(MenuOptions.DeleteAccount);

            Console.SetCursorPosition(22, 7);
            string accountNumber = Console.ReadLine();
            Console.SetCursorPosition(0, 10);

            if (AccountExists(accountNumber)) {
                Account(Convert.ToInt32(accountNumber)).PrintAccountDetails();
                Console.Write(" Delete account (Y/N)? ");
                ReadChoice(ref choice, ref choice, MenuOptions.DeleteAccount, Convert.ToInt32(accountNumber));
            }
            else {
                Console.WriteLine(" Invalid account number.");
                Console.Write(" Retry (Y/N)? ");
                ReadChoice(ref choice, ref choice, MenuOptions.DeleteAccount2);
            }
        }
        
        // Reads the user input from console and executes specified commands based on the input.
        private void ReadChoice(ref ConsoleKey choice1, ref ConsoleKey choice2, MenuOptions option, int accountNumber = 0) {
            do {
                choice2 = Console.ReadKey().Key;
                switch (choice2) {
                    case ConsoleKey.Y:
                        if (option == MenuOptions.LoginMenu)
                            LoginMenu(ref choice2);
                        else if (option == MenuOptions.CreateAccount)
                            CreateAccount(ref choice1, ref choice2);
                        else if (option == MenuOptions.SearchAccount)
                            SearchAccount(ref choice2);
                        else if (option == MenuOptions.Deposit)
                            Deposit(ref choice2);
                        else if (option == MenuOptions.Withdraw)
                            Withdraw(ref choice2);
                        else if (option == MenuOptions.ViewStatement) {
                            choice2 = ConsoleKey.N;
                            Account(accountNumber).SendEmail(EmailOptions.Statement);
                            Console.WriteLine("\n Email has been sent.");
                        }
                        else if (option == MenuOptions.ViewStatement2)
                            ViewStatement(ref choice2);
                        else if (option == MenuOptions.DeleteAccount) {
                            accounts.Remove(Account(accountNumber));
                            File.Delete($"{accountNumber}.txt");
                            Console.WriteLine("\n Account deleted successfully.");
                            Console.Write("\n Delete another account (Y/N)? ");
                            ReadChoice(ref choice1, ref choice2, MenuOptions.DeleteAccount2);
                        }
                        else if (option == MenuOptions.DeleteAccount2)
                            DeleteAccount(ref choice2);
                        break;

                    case ConsoleKey.N:
                        break;

                    default:
                        Console.Write("\b \b");
                        break;
                }
            } while (choice2 != ConsoleKey.N);
        }

        // Checks whether an account exists or not. Returns true if exists, false otheriwse.
        // Also re-adds an existing account back to the system if its <account_number>.txt file is found,
        // but the account itself is not found in the system.
        private bool AccountExists(string accountNumber) {
            if (accountNumber.Length >= 6 && accountNumber.Length <= 8 &&
                Int32.TryParse(accountNumber, out int accountNumberInt) && File.Exists($"{accountNumberInt}.txt")) {

                if (Account(accountNumberInt) == null) {
                    string[] accountInfo = File.ReadAllLines($"{accountNumberInt}.txt").Take(7).ToArray();

                    try {
                        BankAccount existingAccount = new BankAccount(accountNumberInt, Convert.ToDouble(accountInfo[1]),
                                accountInfo[2], accountInfo[3], accountInfo[4], accountInfo[5], accountInfo[6],
                                AccountType.Existing);
                        accounts.Add(existingAccount);
                        existingAccount.ReAddExistingStatement();
                    }
                    catch (Exception ex) when (ex is IndexOutOfRangeException || ex is FormatException) {
                        return false;
                    }
                }
                return true;
            }
            else {
                return false;
            }
        }

        // Searches and returns the bank account if exists, returns null otherwise.
        private BankAccount Account(int accountNumber) {
            foreach (BankAccount account in accounts) {
                if (account.HasNumber(accountNumber))
                    return account;
            }
            return null;
        }

        // Prints the login menu to console.
        private void PrintLoginMenu() {
            Console.WriteLine(" _____________________________________________________________");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |          WELCOME TO SIMPLE BANK MANAGEMENT SYSTEM         |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                          SIGN IN                          |");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |    Username:                                              |");
            Console.WriteLine(" |    Password:                                              |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine();
        }

        // Prints the main menu to console.
        private void PrintMainMenu() {
            Console.WriteLine(" _____________________________________________________________");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |          WELCOME TO SIMPLE BANK MANAGEMENT SYSTEM         |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |    1. Create new account                                  |");
            Console.WriteLine(" |    2. Search an account                                   |");
            Console.WriteLine(" |    3. Deposit                                             |");
            Console.WriteLine(" |    4. Withdraw                                            |");
            Console.WriteLine(" |    5. View account statements                             |");
            Console.WriteLine(" |    6. Delete account                                      |");
            Console.WriteLine(" |    7. Exit                                                |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |    Enter your choice:                                     |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine();
        }

        // Prints the account creation menu to console.
        private void PrintAccountCreationMenu() {
            Console.WriteLine(" _____________________________________________________________");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                   CREATE A NEW ACCOUNT                    |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                     ENTER THE DETAILS                     |");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |    First Name:                                            |");
            Console.WriteLine(" |    Last Name:                                             |");
            Console.WriteLine(" |    Address:                                               |");
            Console.WriteLine(" |    Phone:                                                 |");
            Console.WriteLine(" |    Email:                                                 |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine();
        }

        // Prints the specified menu to console based on the option.
        private void PrintMenu(MenuOptions option) {
            Console.WriteLine(" _____________________________________________________________");
            Console.WriteLine(" |                                                           |");
            if (option == MenuOptions.SearchAccount)
                Console.WriteLine(" |                     SEARCH AN ACCOUNT                     |");
            else if (option == MenuOptions.DeleteAccount)
                Console.WriteLine(" |                     DELETE AN ACCOUNT                     |");
            else if (option == MenuOptions.ViewStatement)
                Console.WriteLine(" |                       VIEW STATEMENT                      |");
            else if (option == MenuOptions.Deposit)
                Console.WriteLine(" |                          DEPOSIT                          |");
            else if (option == MenuOptions.Withdraw)
                Console.WriteLine(" |                         WITHDRAW                          |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                     ENTER THE DETAILS                     |");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |    Account Number:                                        |");
            if (option == MenuOptions.Deposit || option == MenuOptions.Withdraw)
                Console.WriteLine(" |    Amount: $                                              |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine();
        }
    }
}
