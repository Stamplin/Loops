using System;

class CoinCasinoGame
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        int coinFlip, userPoints = 3, userGuess;

        //intro and rules
        Console.WriteLine("\r\n░███████╗  ░█████╗░░█████╗░██╗███╗░░██╗  ░█████╗░░█████╗░░██████╗██╗███╗░░██╗░█████╗░  ░███████╗\r\n██╔██╔══╝  ██╔══██╗██╔══██╗██║████╗░██║  ██╔══██╗██╔══██╗██╔════╝██║████╗░██║██╔══██╗  ██╔██╔══╝\r\n╚██████╗░  ██║░░╚═╝██║░░██║██║██╔██╗██║  ██║░░╚═╝███████║╚█████╗░██║██╔██╗██║██║░░██║  ╚██████╗░\r\n░╚═██╔██╗  ██║░░██╗██║░░██║██║██║╚████║  ██║░░██╗██╔══██║░╚═══██╗██║██║╚████║██║░░██║  ░╚═██╔██╗\r\n███████╔╝  ╚█████╔╝╚█████╔╝██║██║░╚███║  ╚█████╔╝██║░░██║██████╔╝██║██║░╚███║╚█████╔╝  ███████╔╝\r\n╚══════╝░  ░╚════╝░░╚════╝░╚═╝╚═╝░░╚══╝  ░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝╚═╝░░╚══╝░╚════╝░  ╚══════╝░");
        Console.WriteLine("================================= \r\n Welcome to the Coin Casino Game!");
        Console.WriteLine("================================= \r\n How to play: You will choose heads or tails. If you guessed correctly, you win a point. If you guessed incorrectly, you lose a point.");
        Console.WriteLine("================================= \r\n You start with: " + userPoints + " Points");

        while (userPoints > 0)
        {
            //0 = heads; 1 = tails
            coinFlip = generator.Next(2);

            Console.WriteLine("================================= \r\n Would you like to bet on: \r\n 1. Heads \r\n 2. Tails");
            int.TryParse(Console.ReadLine(), out userGuess);

            //make sure it correct input
            while (userGuess < 1 || userGuess > 2)
            {
                Console.WriteLine("!!ERROR!! Please input \" 1 \" or \" 2 \" ");
                int.TryParse(Console.ReadLine(), out userGuess);
            }

            //show the result of the flip
            if (coinFlip == 0)
            {
                Console.WriteLine("\nIt is Heads!");
            }
            else
            {
                Console.WriteLine("\nIt is Tails!");
            }

            //make sure the answer is correct
            if ((coinFlip == 0 && userGuess == 1) || (coinFlip == 1 && userGuess == 2))
            {
                Console.WriteLine("You're correct!");
                userPoints++;
            }
            else
            {
                Console.WriteLine("Incorrect! D:");
                userPoints--;
            }

            //updated points
            Console.WriteLine("You now currently have " + userPoints + " Points.");

            //check user has lost all points
            if (userPoints == 0)
            {
                Console.WriteLine("Game over! You've run out of points.");
                break; //end game when points reach 0
            }

            //play again or exit
            Console.WriteLine("\nPress Enter to play again or type 'exit' to quit.");
            string playAgain = Console.ReadLine();
            if (playAgain.ToLower() == "exit") //convert line to smaller and exit loop
            {
                break;
            }

            Console.Clear();
        }

        //Game Over 
        Console.WriteLine("\r\n░██████╗░░█████╗░███╗░░░███╗███████╗  ░█████╗░██╗░░░██╗███████╗██████╗░\r\n██╔════╝░██╔══██╗████╗░████║██╔════╝  ██╔══██╗██║░░░██║██╔════╝██╔══██╗\r\n██║░░██╗░███████║██╔████╔██║█████╗░░  ██║░░██║╚██╗░██╔╝█████╗░░██████╔╝\r\n██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░  ██║░░██║░╚████╔╝░██╔══╝░░██╔══██╗\r\n╚██████╔╝██║░░██║██║░╚═╝░██║███████╗  ╚█████╔╝░░╚██╔╝░░███████╗██║░░██║\r\n░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝  ░╚════╝░░░░╚═╝░░░╚══════╝╚═╝░░╚═╝");
        Console.ReadLine();
    }
}
