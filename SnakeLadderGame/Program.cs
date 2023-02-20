namespace SnakeLadderGame
{
    internal class SnakeLadder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder Game");

            int position = 0 ;
            int playerOne;
            playerOne = position;
            Console.WriteLine("Position of the playerOne is " +playerOne);
            Random random = new Random();
            int diceCheck = random.Next(0, 7);
            Console.WriteLine("Rolled Dice number is " +diceCheck);
        }
    }
}