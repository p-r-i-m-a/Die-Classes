namespace Die_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playing = false;

            Console.WriteLine("Welcome to the dice game! You will be");

            Die die1 = new Die();
            die1.DrawRoll();
            Console.WriteLine(die1.Roll);
        }
    }
}