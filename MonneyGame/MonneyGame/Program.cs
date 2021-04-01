using System;
using System.Diagnostics;

namespace MonneyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int pennies;
            int nicles;
            int dimes;
            int quarters;
            int total;
            bool exit = true;

            
            {

                Console.WriteLine("MENU");
                Console.WriteLine("1. Start game");
                Console.WriteLine("2. Exit");
                //menu = Convert.ToInt32(Console.ReadLine());



                do
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("Welcome to the monney game,instructions:enter an amount of pennies,nicles,dimes, and quarters to make a dollar, if there is to less you lose if there is to much you lose");
                            Console.Write("Press any key to continue");
                            Console.ReadKey();
                            Console.Write("Please enter your amount of pennies");
                            pennies = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please enter your amount of nicles");
                            nicles = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please enter your amount of dimes");
                            dimes = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please enter your amount of quarters");
                            quarters = Convert.ToInt32(Console.ReadLine());

                            nicles = nicles * 5;
                            dimes = dimes * 10;
                            quarters = quarters * 25;

                            total = pennies + nicles + dimes + quarters;

                            if (total > 100)
                            {
                                Console.Write("You lose the number was to big:" + total);
                            }
                            else if (total < 100)
                            {
                                Console.Write("You lose the number was to small:" + total);
                            }
                            else if (total == 100)
                            {
                                Console.Write("You win you got to one dollar");

                            }
                            break;

                        case "2":
                            exit = false;

                            break;
                        default:
                            Console.WriteLine("Please enter a number from the menu");
                            break;

                    } 
                
                } while (exit);
            } 
;        }
    }
}
