namespace Die_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bet;
            double betAmount, wallet = 100;
            bool playing = false;
            bool done = false;

            Console.WriteLine("Welcome to the dice game, in this game you may bet on the outcome of two dice that will be rolled. You have $100 in your 'wallet'. \n\r \n\r Please enter the amount you wish to bet:");
            Console.WriteLine();
            Console.WriteLine("Please chose a number between 2 and 12: ");
            Console.WriteLine();
            bet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number you are betting on is " + bet);
            Console.WriteLine();

            do
            {
                Console.WriteLine("Please enter the amount you want to bet from your wallet:");
                Console.WriteLine();
                betAmount = Convert.ToDouble(Console.ReadLine());
                if (betAmount <= 0)
                {
                    Console.WriteLine("That bet is below 0.");
                    Console.WriteLine() ;
                }
                else if (betAmount >= wallet)
                {
                    betAmount = wallet;
                    Console.WriteLine("You have set your bet higher than whats in your wallet. Bet has been set to current wallet max.");
                    Console.WriteLine();
                    done = true;
                }
                else if (betAmount >= 0 )
                {
                    done = true;
                }
            }while (!done) ;

            Console.WriteLine("You have bet" + betAmount);
            Console.WriteLine();
            Console.WriteLine("If you wish to proceed, enter Y, if you wish to make a different bet, enter N.");

           

            wallet = wallet - betAmount;
            Console.Clear();
            Console.WriteLine("Your bet is: " + betAmount);
            Console.WriteLine();
            




            Die die1 = new Die();
            die1.DrawRoll();
            Console.WriteLine(die1.Roll);
        }
    }
}