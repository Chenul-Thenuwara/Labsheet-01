using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_01_Q7
{
    
        class Program
        {
            static decimal accountBalance = 1000.0m; // Initial account balance

            static void Main()
            {
                Console.WriteLine("Welcome to the ATM Simulator!");

                while (true)
                {
                    Console.WriteLine("\nChoose an option:");
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Deposit Money");
                    Console.WriteLine("3. Withdraw Money");
                    Console.WriteLine("4. Exit");

                    int choice;
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                CheckBalance();
                                break;
                            case 2:
                                DepositMoney();
                                break;
                            case 3:
                                WithdrawMoney();
                                break;
                            case 4:
                                Console.WriteLine("Thank you for using the ATM. Goodbye!");
                                return;
                            default:
                                Console.WriteLine("Invalid choice. Please enter a valid option.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid numeric option.");
                    }
                }
            }

            static void CheckBalance()
            {
                Console.WriteLine($"Your account balance is: {accountBalance:C}");
            }

            static void DepositMoney()
            {
                Console.WriteLine("Enter the amount to deposit:");
                if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount) && depositAmount > 0)
                {
                    accountBalance += depositAmount;
                    Console.WriteLine($"Deposit successful. Your new balance is: {accountBalance:C}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive amount to deposit.");
                }
            }

            static void WithdrawMoney()
            {
                Console.WriteLine("Enter the amount to withdraw:");
                if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount) && withdrawAmount > 0)
                {
                    if (withdrawAmount <= accountBalance)
                    {
                        accountBalance -= withdrawAmount;
                        Console.WriteLine($"Withdrawal successful. Your new balance is: {accountBalance:C}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds. Unable to withdraw.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive amount to withdraw.");
                }
            }
        }
    }
