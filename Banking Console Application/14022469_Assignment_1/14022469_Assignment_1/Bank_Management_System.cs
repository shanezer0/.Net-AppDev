using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14022469_Assignment_1
{
    
        public class Bank_Management_System
        {

            private List<Bank_Account> accounts;

            public Bank_Management_System()
            {
                accounts = new List<Bank_Account>();
            }

            public static void Main(string[] args)
            {
                ConsoleKey choice = 0;
                new Bank_Management_System().LoginMenu(ref choice);
            }

            // Login menu.
            private void LoginMenu(ref ConsoleKey choice)
            {
                Console.Clear();
                
           
                PrintLoginMenu();

                Console.SetCursorPosition(16, 7);
                string username = Console.ReadLine();
                Console.SetCursorPosition(16, 8);
                string password = "";
                ConsoleKeyInfo key;
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                    {
                        password = password.Remove(password.Length - 1);
                        Console.Write("\b \b");
                    }
                    else if (key.Key != ConsoleKey.Spacebar && key.Key != ConsoleKey.Enter &&
                             key.Key != ConsoleKey.Escape && key.Key != ConsoleKey.Tab &&
                             key.Key != ConsoleKey.Backspace && key.KeyChar != '\u0000')
                    {
                        password += key.KeyChar;
                        Console.Write("*");
                    }
                } while (key.Key != ConsoleKey.Enter);
                Console.SetCursorPosition(0, 11);

                
                String path = Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\login.txt"));


            if (File.Exists(path))
                {
                    bool loginSuccessful = false;
                    string[] loginCredentials = File.ReadAllLines(path);
                    try
                    {
                        foreach (string loginCredential in loginCredentials)
                        {
                            string[] separator = { "|", " " };
                            string[] login = loginCredential.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                            if (username == login[0] && password == login[1])
                            {
                                loginSuccessful = true;
                                choice = ConsoleKey.N;
                                MainMenu();
                                break;
                            }
                        }
                        if (!loginSuccessful)
                        {
                            Console.WriteLine(" Incorrect username or password.");
                            Console.Write(" Retry (Y/N)? ");
                            ReadChoice(ref choice, ref choice, MenuOptions.LoginMenu);
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        choice = ConsoleKey.N;
                        Console.WriteLine(" Error: login.txt does not contain login credentials in the correct format.\n");
                        Console.Write(" Press any key to exit... ");
                        Console.ReadKey();
                    }
                }
                else
                {
                    choice = ConsoleKey.N;
                    Console.WriteLine(" Error: login.txt is missing.\n");
                    Console.Write(" Press any key to exit... ");
                    Console.ReadKey();
                }
            }

            // Main menu.
            private void MainMenu()
            {
                ConsoleKey choice = 0;
                ConsoleKey choice1 = 0;
                ConsoleKey choice2 = 0;
                bool lastInputInvalid = false;

                while (choice != ConsoleKey.D7)
                {
                    Console.Clear();
                    PrintMainMenu();
                    if (lastInputInvalid)
                        Console.WriteLine("Incorrect Input!!! Specify a value between 1 and 7...");
                    lastInputInvalid = false;

                    Console.SetCursorPosition(30, 14);
                    choice = Console.ReadKey().Key;

                    switch (choice)
                    {
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

            // Account creation menu.
            private void CreateAccount(ref ConsoleKey choice1, ref ConsoleKey choice2)
            {
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
                Console.Write(" Is the information correct (Y/N)? ");

                do
                {
                    choice1 = Console.ReadKey().Key;
                    switch (choice1)
                    {

                        case ConsoleKey.Y:
                            Console.WriteLine();
                            if (Int64.TryParse(phoneNumber, out long phoneNumberInt) && phoneNumber.Length == 10)
                            {
                                int accountNumber;
                                do
                                {
                                    accountNumber = new Random().Next(100000, 999999);
                                } while (File.Exists($"{accountNumber}.txt"));
                                Bank_Account newAccount = new Bank_Account(accountNumber, 0, firstName, lastName,
                                        address, phoneNumber, email, AccountType.New);

                                if (newAccount.SendEmail(EmailOptions.AccountInfo))
                                {
                                    accounts.Add(newAccount);
                                    newAccount.UpdateFile();
                                    Console.WriteLine(" Account created successfully! detials will be provided via email");
                                    
                                    Console.WriteLine($" Account number is: {accountNumber}");
                                    Console.Write("\n Create another account (Y/N)? ");
                                    ReadChoice(ref choice1, ref choice2, MenuOptions.CreateAccount);
                                }

                                else
                                {
                                    Console.WriteLine(" Invalid email address.");
                                    Console.Write(" Retry (Y/N)? ");
                                    ReadChoice(ref choice1, ref choice2, MenuOptions.CreateAccount);
                                }
                            }

                            else
                            {
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

            // Search Account
            private void SearchAccount(ref ConsoleKey choice)
            {
                Console.Clear();
                PrintMenu(MenuOptions.SearchAccount);

                Console.SetCursorPosition(22, 7);
                string accountNumber = Console.ReadLine();
                Console.SetCursorPosition(0, 10);

                if (AccountExists(accountNumber))
                {
                    Account(Convert.ToInt32(accountNumber)).PrintAccountDetails();
                    Console.Write(" Check another account (Y/N)? ");
                    ReadChoice(ref choice, ref choice, MenuOptions.SearchAccount);
                }
                else
                {
                    Console.WriteLine(" Account not found!");
                    Console.Write(" Check another account (Y/N)? ");
                    ReadChoice(ref choice, ref choice, MenuOptions.SearchAccount);
                }
            }

            //Deposit menu.
            private void Deposit(ref ConsoleKey choice)
            {
                Console.Clear();
                PrintMenu(MenuOptions.Deposit);

                Console.SetCursorPosition(22, 7);
                string accountNumber = Console.ReadLine();

                if (AccountExists(accountNumber))
                {
                Console.WriteLine("\n \n Account Found! Enter The Amount");
                Console.SetCursorPosition(15, 8);
                    string tempAmount = Console.ReadLine();
                
                Console.SetCursorPosition(0, 11);
                

                if (Double.TryParse(tempAmount, out double amount))
                    {
                        
                        Account(Convert.ToInt32(accountNumber)).Deposit(amount);
                        Console.WriteLine(" Deposit successful!");
                        Console.Write("\n Make another deposit (Y/N)? ");
                        ReadChoice(ref choice, ref choice, MenuOptions.Deposit);
                    }

                    else
                    {
                        Console.WriteLine(" Invalid amount.");
                        Console.Write(" Retry (Y/N)? ");
                        ReadChoice(ref choice, ref choice, MenuOptions.Deposit);
                    }
                }

                else
                {
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine(" Account not found!");
                    Console.Write(" Retry (Y/N)? ");
                    ReadChoice(ref choice, ref choice, MenuOptions.Deposit);
                }
            }

            // Withdraw menu.
            private void Withdraw(ref ConsoleKey choice)
            {
                Console.Clear();
                PrintMenu(MenuOptions.Withdraw);

                Console.SetCursorPosition(22, 7);
                string accountNumber = Console.ReadLine();

                if (AccountExists(accountNumber))
                {
                Console.WriteLine("\n \n Account Found! Enter The Amount");
                Console.SetCursorPosition(15, 8);
                    string tempAmount = Console.ReadLine();
                    Console.SetCursorPosition(0, 11);

                    if (Double.TryParse(tempAmount, out double amount))
                    {

                        if (Account(Convert.ToInt32(accountNumber)).HasSufficientFunds(amount))
                        {
                            Account(Convert.ToInt32(accountNumber)).Withdraw(amount);
                            Console.WriteLine(" Withdraw successful.");
                            
                            ReadChoice(ref choice, ref choice, MenuOptions.Withdraw);
                        }

                        else
                        {
                            Console.WriteLine(" Insufficient funds.");
                            Console.Write(" Retry (Y/N)? ");
                            ReadChoice(ref choice, ref choice, MenuOptions.Withdraw);
                        }
                    }

                    else
                    {
                        Console.WriteLine(" Invalid amount.");
                        Console.Write(" Retry (Y/N)? ");
                        ReadChoice(ref choice, ref choice, MenuOptions.Withdraw);
                    }
                }

                else
                {
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine(" Account not found!");
                    Console.Write(" Retry (Y/N)? ");
                    ReadChoice(ref choice, ref choice, MenuOptions.Withdraw);
                }
            }

            // Statement Menu
            private void ViewStatement(ref ConsoleKey choice)
            {
                Console.Clear();
                PrintMenu(MenuOptions.ViewStatement);

                Console.SetCursorPosition(22, 7);
                string accountNumber = Console.ReadLine();
                Console.SetCursorPosition(0, 10);

                if (AccountExists(accountNumber))
                {
                    Account(Convert.ToInt32(accountNumber)).PrintStatement();
                    
                    Console.Write("\n View another statement (Y/N)? ");
                    ReadChoice(ref choice, ref choice, MenuOptions.ViewStatement2);
                }
                else
                {
                    Console.WriteLine(" Invalid account number.");
                    Console.Write(" Retry (Y/N)? ");
                    ReadChoice(ref choice, ref choice, MenuOptions.ViewStatement2);
                }
            }

            // Delete Account.
            private void DeleteAccount(ref ConsoleKey choice)
            {
                Console.Clear();
                PrintMenu(MenuOptions.DeleteAccount);

                Console.SetCursorPosition(22, 7);
                string accountNumber = Console.ReadLine();
                Console.SetCursorPosition(0, 10);

                if (AccountExists(accountNumber))
                {
                    Account(Convert.ToInt32(accountNumber)).PrintAccountDetails();
                    Console.Write(" Delete account (Y/N)? ");
                    ReadChoice(ref choice, ref choice, MenuOptions.DeleteAccount, Convert.ToInt32(accountNumber));
                }
                else
                {
                    Console.WriteLine(" Invalid account number.");
                    Console.Write(" Retry (Y/N)? ");
                    ReadChoice(ref choice, ref choice, MenuOptions.DeleteAccount2);
                }
            }

            // Get input data
            private void ReadChoice(ref ConsoleKey choice1, ref ConsoleKey choice2, MenuOptions option, int accountNumber = 0)
            {
                do
                {
                    choice2 = Console.ReadKey().Key;
                    switch (choice2)
                    {
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
                            
                            else if (option == MenuOptions.ViewStatement2)
                                ViewStatement(ref choice2);
                            else if (option == MenuOptions.DeleteAccount)
                            {
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

            
            private bool AccountExists(string accountNumber)
            {
                if (accountNumber.Length >= 6 && accountNumber.Length <= 8 &&
                    Int32.TryParse(accountNumber, out int Acc_Number) && File.Exists($"{Acc_Number}.txt"))
                {

                    if (Account(Acc_Number) == null)
                    {
                        string[] accountInfo = File.ReadAllLines($"{Acc_Number}.txt").Take(7).ToArray();

                        try
                        {
                            Bank_Account existingAccount = new Bank_Account(Acc_Number, Convert.ToDouble(accountInfo[1]),
                                    accountInfo[2], accountInfo[3], accountInfo[4], accountInfo[5], accountInfo[6],
                                    AccountType.Existing);
                            accounts.Add(existingAccount);
                            existingAccount.ReAddExistingStatement();
                        }
                        catch (Exception ex) when (ex is IndexOutOfRangeException || ex is FormatException)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // search account.
            private Bank_Account Account(int accountNumber)
            {
                foreach (Bank_Account account in accounts)
                {
                    if (account.HasNumber(accountNumber))
                        return account;
                }
                return null;
            }

            // Login menu 
            private void PrintLoginMenu()
            {
                Console.WriteLine(" *************************************************************");
                Console.WriteLine(" *                                                           *");
                Console.WriteLine(" *            WELCOME TO SIMPLE BANK MANAGEMENT SYSTEM       *");
                Console.WriteLine(" *                                                           *");
                Console.WriteLine(" *************************************************************");
                Console.WriteLine(" *                                                           *");
                Console.WriteLine(" *                          SIGN IN                          *");
                //Console.WriteLine(" *                                                           *");
                Console.WriteLine(" *    Username:                                              *");
                Console.WriteLine(" *    Password:                                              *");
                //Console.WriteLine(" *                                                           *");
                Console.WriteLine(" *                                                           *");
                Console.WriteLine(" *************************************************************");
                Console.WriteLine();
            }

            // Main menu
            private void PrintMainMenu()
            {
                Console.WriteLine(" *************************************************************");
                Console.WriteLine(" *                                                           *");
                Console.WriteLine(" *          WELCOME TO SIMPLE BANK MANAGEMENT SYSTEM         *");
                Console.WriteLine(" *************************************************************");
                Console.WriteLine(" *                                                           *");
                Console.WriteLine(" *    1. Create a new account                                *");
                Console.WriteLine(" *    2. Search for an account                               *");
                Console.WriteLine(" *    3. Deposit                                             *");
                Console.WriteLine(" *    4. Withdraw                                            *");
                Console.WriteLine(" *    5. A/C statements                                      *");
                Console.WriteLine(" *    6. Delete account                                      *");
                Console.WriteLine(" *    7. Exit                                                *");
                Console.WriteLine(" *************************************************************");
                Console.WriteLine(" *                                                           *");
                Console.WriteLine(" *    Enter your choice(1-7):                                *");
                Console.WriteLine(" *************************************************************");
                Console.WriteLine();
            }

            // Account creation menu
            private void PrintAccountCreationMenu()
            {
                Console.WriteLine(" *************************************************************");
                Console.WriteLine(" *                                                           *");
                Console.WriteLine(" *                   CREATE A NEW ACCOUNT                    *");
                Console.WriteLine(" *************************************************************");
                Console.WriteLine(" *                                                           *");
                Console.WriteLine(" *                     ENTER THE DETAILS                     *");
                Console.WriteLine(" *                                                           *");
                Console.WriteLine(" *    First Name:                                            *");
                Console.WriteLine(" *    Last Name:                                             *");
                Console.WriteLine(" *    Address:                                               *");
                Console.WriteLine(" *    Phone:                                                 *");
                Console.WriteLine(" *    Email:                                                 *");
                Console.WriteLine(" *************************************************************");
                Console.WriteLine();
            }

            // Menu.
            private void PrintMenu(MenuOptions option)
            {
                Console.WriteLine(" *************************************************************");
                Console.WriteLine(" *                                                           *");
                if (option == MenuOptions.SearchAccount)
                    Console.WriteLine(" *                     SEARCH AN ACCOUNT                     *");
                else if (option == MenuOptions.DeleteAccount)
                    Console.WriteLine(" *                     DELETE AN ACCOUNT                     *");
                else if (option == MenuOptions.ViewStatement)
                    Console.WriteLine(" *                       VIEW STATEMENT                      *");
                else if (option == MenuOptions.Deposit)
                    Console.WriteLine(" *                          DEPOSIT                          *");
                else if (option == MenuOptions.Withdraw)
                    Console.WriteLine(" *                         WITHDRAW                          *");
                Console.WriteLine(" *************************************************************");
                Console.WriteLine(" *                                                           *");
                Console.WriteLine(" *                     ENTER THE DETAILS                     *");
                Console.WriteLine(" *                                                           *");
                Console.WriteLine(" *    Account Number:                                        *");
                if (option == MenuOptions.Deposit || option == MenuOptions.Withdraw)
                    Console.WriteLine(" *    Amount: $                                              *");
                Console.WriteLine(" *************************************************************");
                Console.WriteLine();
            }
        }
    }

