using BankAPP.Interfaces;
using BankAPP.Models;
using BankAPP.Services;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        IBankManager bankManager = new BankManager();
        while (true)
        {

            Console.WriteLine("Welcome to Bank of Najot Ta'lim");
        Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Show bank info");
            Console.WriteLine("4. Clear Screen");
            Console.WriteLine("0. Exit");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                //1. bankManager yordamida Regis
                bankManager.Register();
            }
            else if (choice == "2")
            {
                User user = null;
                if (user == null)
                {
                    user = bankManager.Login();
                }
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Select operation:");
                    Console.WriteLine("1. Create card");
                    Console.WriteLine("2. Block card");
                    Console.WriteLine("3. Unblock card");
                    Console.WriteLine("4. Show cards");
                    Console.WriteLine("5. Show balance");
                    Console.WriteLine("6. Show all balance");
                    Console.WriteLine("7. Deposit");
                    Console.WriteLine("8. Withdraw");
                    Console.WriteLine("0. Exit");
                    
                string choice2 = Console.ReadLine();
                    if (choice2 == "1")
                    {
                        //3. bankManager yordamida CreateCard me
                        bankManager.CreateCard(user);
                        Console.Clear();
                    }
                    else if (choice2 == "2")
                    {
                        //4. bankManager yordamida ShowCards met
                        bankManager.ShowCards(user);
                        Console.WriteLine("Enter card number:");
                        string cardNumber = Console.ReadLine();
                        //5. bankManager yordamida BlockCard met
                        bankManager.BlockCard(user, cardNumber);
                    }
                    else if (choice2 == "3")
                    {
                        //6. bankManager
                        
                        Console.WriteLine("Enter card number:");
                        string cardNumber = Console.ReadLine();
                        //7. bankManager yordamida UnBlockCard m
                        bankManager.UnblockCard(user, cardNumber);
                    }
                    else if (choice2 == "4")
                    {
                        //8. bankManager yordamida ShowCards met
                        bankManager.ShowCards(user);
                    }
                    else if (choice2 == "5")
                    {
                        //9. bankManager yordamida ShowCards met
                        bankManager.ShowCards(user);
                        Console.WriteLine("Enter card number:");
                        string cardNumber = Console.ReadLine();
                        //10. bankManager yordamida ShowBalance
                        bankManager.ShowBalance(user, cardNumber);
                        
                    }
                    else if (choice2 == "6")
                    {
                        //11. bankManager yordamida ShowAllBalan
                        bankManager.ShowAllBalances(user);
                    }
                    else if (choice2 == "7")
                    {
                        //12. bankManager yordamida ShowCards me
                        bankManager.ShowCards(user);
                        Console.WriteLine("Enter card number:");
                        string cardNumber = Console.ReadLine();
                        //13. bankManager yordamida Deposit meto
                        bankManager.DepositCard(user, cardNumber);
                    }
                    else if (choice2 == "8")
                    {
                        //14. bankManager yordamida ShowCards me
                        bankManager.ShowCards(user);
                        Console.WriteLine("Enter card number:");
                        string cardNumber = Console.ReadLine();
                        Console.WriteLine("Enter your card pin:");
                       
                        string pin = Console.ReadLine();
                        //15. bankManage
                        bankManager.WithdrawCard(user, cardNumber, pin);
                    }
                }
            }
            else if (choice == "3")
            {
                Console.Clear();
                //16. bankManager yordamida ShowBankInfo metodin
                bankManager.ShowBankInfo();
            }
            else if (choice == "4")
            {
                Console.Clear();
            }
            else if (choice == "0")
               
        {
                break;
            }
        }
    }
}























