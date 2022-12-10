using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Atm
{
    class ATMWithSwitchCase
    {
        private static void Main(string[] args)
        {
            int CardNumber = 1;
            int CardNumberInput;
            int CardPassword = 1;
            int CardPasswordInput;
            int n;
            int balance = 1200;
            string y;
            string transaction;


            Console.WriteLine("-----Welcome to Atm-----");
            Console.Write("Please enter your card number :");

            CardNumberInput = Convert.ToInt32(Console.ReadLine());

            while (CardNumber != CardNumberInput)
            {
                Console.WriteLine("Unknown User");
                Console.Write("Please enter your card number :");
                CardNumberInput = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Please enter your card password :");
            CardPasswordInput = Convert.ToInt32(Console.ReadLine());

            while(CardPassword != CardPasswordInput)
            {
                Console.WriteLine("Wrong Password");
                Console.Write("Please enter your card password :");
                CardPasswordInput = Convert.ToInt32(Console.ReadLine());
            }

            do
            {

                Console.WriteLine("Please select you transaction :");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1-Withdraw");
                Console.WriteLine("2-Deposit");
                Console.WriteLine("3-Balance inquiry");
                Console.WriteLine("q-quit");

                transaction = (Console.ReadLine());

                if (transaction != "q")
                {
                    while (transaction != "q" && transaction != "1" && transaction != "2" && transaction != "3")
                    {
                        Console.WriteLine("Please press a valid key ");
                        transaction = Console.ReadLine();
                    }

                    switch (transaction)
                    {
                        case "1":

                            Console.WriteLine("Please enter amount you want to withdraw :");
                            n = Convert.ToInt32(Console.ReadLine());
                            while (n > balance)
                            {
                                Console.WriteLine("You can't withdraw more than your balance! \nPlease enter a valid value :");
                                n = Convert.ToInt32(Console.ReadLine());
                            }

                            balance -= n;

                            Console.WriteLine("Your Balance :" + balance + "$");

                            break;

                        case "2":
                            Console.WriteLine("Please enter amount you want to deposit :");
                            n = Convert.ToInt32(Console.ReadLine());

                            balance += n;

                            Console.WriteLine("Your Balance :" + balance + "$");
                            break;

                        case "3":
                            Console.WriteLine("Your Balance :" + balance);
                            break;

                    }
                }
               
                else
                {
                    break;
                }
                

                Console.WriteLine("Do you want to do another transaction ? \n Press y " );
                y = Console.ReadLine();

            } while (y == "y");

            Console.WriteLine("Good Bye! \n we hope you have a good day ");

            Console.ReadKey();
        }
    }
}
