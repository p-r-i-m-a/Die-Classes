using System.Numerics;

namespace Die_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roll1, roll2, totalRoll, bet;
            double betAmount, wallet = 100;
            bool playing = false, done = false, chosing = false;
            
            string chose;

            do
            {
                Console.WriteLine("Welcome to the dice game, in this game you may bet on the outcome of two dice that will be rolled. \n\rYou have $100 in your 'wallet'.");
                Console.WriteLine();
                do
                {
                    done = false;
                    Console.WriteLine("Please enter the amount you want to bet from your wallet:");
                    Console.WriteLine();
                    betAmount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    if (betAmount <= 0)
                    {
                        Console.WriteLine("That bet is below 0.");
                        Console.WriteLine();
                    }
                    else if (betAmount >= wallet)
                    {
                        betAmount = wallet;
                        Console.WriteLine("You have set your bet higher than whats in your wallet. Bet has been set to current wallet max.");
                        Console.WriteLine();
                        done = true;
                    }
                    else if (betAmount >= 0)
                    {
                        done = true;
                    }
                } while (!done);



                do
                {
                    done = false;
                    Console.WriteLine("Please chose a number between 2 and 12: ");
                    Console.WriteLine();
                    bet = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (bet > 12 || bet < 2)
                    {
                        done = false;
                    }
                    else
                    {
                        done = true;
                    }

                } while (!done);


                Console.WriteLine();



                Console.WriteLine("You have bet " + betAmount + "$. You bet on number " + bet);
                Console.WriteLine();
                Console.WriteLine("If you wish to proceed, enter Y, if you wish to make different bets, enter N.");
                Console.WriteLine();
                chose = Console.ReadLine();

                while (chose != "Y" || chose != "N")
                {
                    Console.WriteLine("Please enter eiter Y, or N.");
                    Console.WriteLine();
                    chose = Console.ReadLine();
                }

                chose.ToLower();

                if (chose == "n")
                {
                    chosing = false;
                }
                else
                {
                    chosing = true;
                }
            } while (!chosing);


            wallet = wallet - betAmount;
            Console.Clear();
            Console.WriteLine("You bet: " + betAmount);
            Console.WriteLine() ;
            Console.WriteLine("You bet on: #" + bet);
            Console.WriteLine();
            Console.WriteLine("Press 'enter' to continue.");
            Console.WriteLine();

            Die die1 = new Die();
            Die die2 = new Die();

            die1.DrawRoll();
            die2.DrawRoll();

            Console.WriteLine(die1.Roll);
            Console.WriteLine();
            Console.WriteLine(die2.Roll);

            roll1 = Convert.ToInt32(die1.Roll);
            roll2 = Convert.ToInt32(die2.Roll);
            totalRoll = roll1 + roll2;

            Console.WriteLine("You rolled a " + totalRoll);
            Console.WriteLine();
            if (totalRoll == bet)
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("You lost :(");
            }
        }
    }
}