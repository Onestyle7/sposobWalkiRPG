namespace sposobWalkiRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            

            int playerLife = 10;
            int monsterLife = 10;

            do
            {
               int roll = random.Next(1, 11);
               monsterLife -= roll;
               Console.WriteLine($"Monster was damaged and lost {roll} and now has {monsterLife} healt");

               if (monsterLife <= 0) continue;

               roll = random.Next(1, 11);
               playerLife -= roll;
               Console.WriteLine($"Player was damaged and lost {roll} and now has {playerLife} healt");

            } while(monsterLife > 0 && playerLife >0);

            Console.WriteLine(playerLife>monsterLife ? "PLAYER WIN!": "MONSTER WIN!" );
        }
    }
}