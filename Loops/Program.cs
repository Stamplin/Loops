////guessing game one
//Random generator = new Random();
//int spesNUM = generator.Next(11);
//int entry;

//Console.WriteLine("Guess da number");
//Console.WriteLine("WHAT U THINK IS IT??");
//int.TryParse(Console.ReadLine(), out entry);
//Console.WriteLine();

//while (entry != spesNUM)
//{
//    Console.WriteLine("Incorrect num. Try again!");
//    Console.WriteLine("what ya guess the num is?");
//    int.TryParse(Console.ReadLine(), out entry);
//    Console.WriteLine();
//}
//Console.WriteLine("correct! it is " + spesNUM);
//Console.ReadLine();

////dice game two
//int dice1, dice2;
//dice1 = generator.Next(7);
//dice2 = generator.Next(7);
//while (dice1 != dice2)
//{
//    dice1 = generator.Next(7);
//    dice2 = generator.Next(7);
//}
//Console.WriteLine(dice1); Console.WriteLine(dice2);



//Simple Casino Game

using System.Runtime.InteropServices;

Random generator = new Random();
int coinFlip, userPoints, userGuess;
userPoints = 3;
coinFlip = generator.Next(2);
Console.WriteLine("\r\n░███████╗  ░█████╗░░█████╗░██╗███╗░░██╗  ░█████╗░░█████╗░░██████╗██╗███╗░░██╗░█████╗░  ░███████╗\r\n██╔██╔══╝  ██╔══██╗██╔══██╗██║████╗░██║  ██╔══██╗██╔══██╗██╔════╝██║████╗░██║██╔══██╗  ██╔██╔══╝\r\n╚██████╗░  ██║░░╚═╝██║░░██║██║██╔██╗██║  ██║░░╚═╝███████║╚█████╗░██║██╔██╗██║██║░░██║  ╚██████╗░\r\n░╚═██╔██╗  ██║░░██╗██║░░██║██║██║╚████║  ██║░░██╗██╔══██║░╚═══██╗██║██║╚████║██║░░██║  ░╚═██╔██╗\r\n███████╔╝  ╚█████╔╝╚█████╔╝██║██║░╚███║  ╚█████╔╝██║░░██║██████╔╝██║██║░╚███║╚█████╔╝  ███████╔╝\r\n╚══════╝░  ░╚════╝░░╚════╝░╚═╝╚═╝░░╚══╝  ░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝╚═╝░░╚══╝░╚════╝░  ╚══════╝░");
Console.WriteLine("================================= \r\n Welcome to the Coin Casino Game!");
Console.WriteLine("================================= \r\n How to play: You will choose heads or tail, If you guessed correctly, you win a point, \r\n however if you chose incorrectly, you lose a point.");
Console.WriteLine("================================= \r\n You currently have: " + userPoints + (" Points"));
Console.WriteLine("================================= \r\n Would you like to bet on: \r\n 1. Heads \r\n 2. Tails");
int.TryParse(Console.ReadLine(), out userGuess);

//make sure input is correct
while (userGuess < 1 || userGuess > 2 )
{
    Console.WriteLine("!!ERROR!! Please input \" 1 \" or \" 2 \" ");
    Console.WriteLine("Would you like to bet on: \r\n 1. Heads \r\n 2. Tails");
    int.TryParse(Console.ReadLine(), out userGuess);
}

while (userPoints > 0)
{
    //tell user what side the coin got
    if (coinFlip == 0) //head flip
    {
        Console.WriteLine("                              ░░░░░░░░                            \r\n                      ▒▒░░░░░░░░░░░░░░░░░░▒▒░░                    \r\n                ░░░░░░░░  ░░░░▒▒▒▒░░  ░░    ░░░░░░                \r\n              ░░░░  ░░▒▒░░░░░░▒▒▒▒░░░░░░  ▒▒▒▒░░░░░░░░            \r\n            ░░░░  ░░▒▒░░░░░░  ░░▒▒░░▒▒░░░░▒▒░░░░░░  ░░░░          \r\n          ░░░░  ░░▒▒░░  ░░░░░░░░░░░░░░░░░░    ▒▒░░░░  ░░░░        \r\n        ░░░░  ▒▒    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒░░  ░░░░      \r\n      ░░░░  ▒▒░░  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░  ░░░░░░  ░░░░    \r\n    ░░░░  ░░▒▒  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░      ░░░░    ░░    \r\n    ░░  ░░░░    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░        ▒▒  ░░░░  \r\n  ░░░░  ░░      ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░        ░░░░  ░░  \r\n  ░░  ░░░░░░  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░        ░░  ░░░░░░\r\n  ░░    ░░    ░░░░▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒          ░░░░  ░░\r\n  ░░  ▒▒░░      ▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒░░          ░░    ░░\r\n░░  ░░▒▒        ▒▒░░░░░░░░░░░░░░░░░░░░░░░░  ░░░░░░        ░░░░  ░░\r\n░░░░░░░░        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░  ░░░░░░      ░░▒▒  ░░\r\n░░░░░░░░        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒        ░░░░░░\r\n░░  ░░░░        ░░░░▒▒░░░░░░░░▒▒░░░░░░░░░░░░░░░░░░          ░░░░░░\r\n░░░░▒▒░░        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒░░░░              ░░\r\n░░░░  ░░          ▒▒░░▒▒░░▒▒░░░░░░░░░░░░░░░░░░░░░░        ░░░░  ░░\r\n░░░░  ░░            ░░░░▒▒░░░░░░░░░░░░░░░░▒▒░░░░          ░░░░  ░░\r\n  ░░  ░░░░              ░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒░░          ░░░░  ░░\r\n  ░░  ░░░░        ░░░░░░░░░░░░░░░░░░░░░░░░                ░░░░░░  \r\n  ░░░░  ░░░░    ░░░░░░░░░░░░░░░░░░░░░░▒▒                ░░░░  ░░  \r\n    ░░  ░░░░░░░░░░░░░░▒▒░░░░░░░░░░░░░░░░                ░░░░░░░░  \r\n    ░░░░░░  ░░░░░░░░░░░░░░░░░░░░░░░░░░                ▒▒░░  ░░    \r\n      ░░░░  ░░░░░░░░░░░░░░░░▒▒░░░░░░░░░░░░          ░░░░░░░░      \r\n      ░░░░  ░░▓▓░░░░░░░░░░░░░░▒▒░░▒▒▒▒░░░░░░      ░░░░░░░░░░      \r\n        ░░░░  ░░██░░░░░░░░░░░░░░▒▒▒▒░░░░░░░░░░░░░░░░░░░░          \r\n          ░░░░░░░░▓▓░░░░░░▒▒░░░░▒▒░░░░▒▒░░░░░░░░    ░░░░          \r\n            ░░░░░░  ▓▓▓▓▒▒░░░░░░░░▒▒▒▒░░░░░░░░▒▒░░░░              \r\n                ░░░░░░  ▒▒▓▓▓▓▒▒▒▒▒▒░░▒▒░░▒▒░░░░░░                \r\n                    ░░░░░░░░          ░░░░░░░░                    \r\n                          ░░░░░░░░░░░░░░                          ");
        Console.WriteLine("\r\n██╗░░██╗███████╗░█████╗░██████╗░░██████╗\r\n██║░░██║██╔════╝██╔══██╗██╔══██╗██╔════╝\r\n███████║█████╗░░███████║██║░░██║╚█████╗░\r\n██╔══██║██╔══╝░░██╔══██║██║░░██║░╚═══██╗\r\n██║░░██║███████╗██║░░██║██████╔╝██████╔╝\r\n╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═════╝░╚═════╝░");
    }
    else if (coinFlip == 1) //tail flip
    {
        Console.WriteLine("                            ░░░░░░░░░░                              \r\n                      ░░░░░░░░  ░░░░░░░░░░░░░░                      \r\n                  ░░░░░░  ░░▒▒▒▒░░▒▒░░░░    ░░░░░░                  \r\n              ░░░░░░░░░░▒▒  ▒▒▒▒▒▒▒▒░░▒▒▒▒░░░░  ░░░░░░              \r\n            ░░░░  ░░░░▒▒░░        ░░░░    ░░▒▒░░░░  ░░░░            \r\n          ░░░░░░░░▒▒              ▒▒▒▒░░      ░░░░░░  ░░░░          \r\n        ░░░░░░▒▒▒▒              ░░░░░░            ░░░░  ░░░░        \r\n      ░░░░  ░░▒▒              ▒▒▒▒▒▒░░                ▒▒  ░░░░      \r\n    ░░░░    ▒▒                ░░▒▒▒▒░░                ░░░░  ░░      \r\n    ░░  ▒▒░░                    ▒▒▒▒                    ░░░░░░░░    \r\n    ░░  ░░▒▒      ▒▒▒▒░░    ▒▒▓▓▒▒▒▒▓▓░░    ▒▒▒▒        ░░░░  ░░    \r\n  ░░░░░░▒▒      ░░▒▒▒▒░░    ▒▒░░▒▒▒▒░░▒▒    ▒▒▒▒▒▒        ░░  ░░░░  \r\n  ░░  ░░░░      ▒▒▒▒▒▒      ▒▒▒▒▒▒▒▒▒▒░░    ▒▒▒▒▒▒░░      ▒▒░░  ░░  \r\n  ░░  ▒▒░░    ▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒      ░░▒▒  ░░  \r\n░░░░░░░░      ▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒      ░░  ░░  \r\n░░░░  ░░    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░    ░░  ░░░░\r\n░░░░░░▒▒    ▒▒░░▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░    ░░░░░░░░\r\n░░░░░░░░    ▒▒▒▒░░░░▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░    ▒▒░░░░░░\r\n░░░░░░░░    ▒▒░░▒▒▒▒▒▒  ░░░░▒▒░░▒▒▒▒░░░░░░▒▒▒▒▒▒░░▒▒▒▒      ░░░░░░░░\r\n░░░░░░░░    ▒▒░░░░▒▒▒▒    ▒▒░░▒▒▒▒▒▒░░░░░░░░░░▒▒░░░░▒▒░░    ░░░░░░░░\r\n░░░░  ░░    ▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒░░░░▒▒▒▒░░░░░░░░░░▒▒░░▒▒░░░░    ░░  ░░  \r\n  ░░  ▒▒░░  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░▒▒░░▒▒░░░░▒▒▒▒░░  ░░    ░░  \r\n  ░░░░▒▒░░  ▒▒▒▒░░  ░░▒▒░░░░░░░░░░▒▒░░░░▒▒░░░░░░░░░░▒▒    ▒▒░░░░    \r\n  ░░░░  ▒▒░░░░░░░░▒▒▒▒  ░░▒▒  ░░▒▒▒▒░░  ░░░░  ▒▒░░▒▒▒▒  ░░    ░░    \r\n    ░░  ▒▒░░  ░░░░░░▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░    ░░░░░░    \r\n    ░░░░  ░░░░        ░░░░▒▒▒▒░░░░▒▒▒▒▒▒▒▒░░  ░░      ░░▒▒  ░░      \r\n      ░░░░░░░░░░          ░░░░▒▒▒▒▒▒▒▒              ░░░░  ░░░░      \r\n        ░░░░▒▒░░                                  ░░░░░░░░░░        \r\n        ░░░░░░░░░░░░                          ░░░░░░░░░░░░          \r\n          ░░░░░░░░░░░░░░      ░░  ░░      ░░░░░░▒▒  ░░░░            \r\n              ░░░░  ░░░░░░▒▒  ░░░░  ░░  ░░▒▒░░░░  ░░░░              \r\n                ░░░░░░  ░░░░  ░░░░░░░░░░░░    ░░░░                  \r\n                    ░░░░░░░░░░        ░░░░░░░░                      \r\n                          ░░░░░░░░░░░░░░░░                          ");
        Console.WriteLine("\r\n████████╗░█████╗░██╗██╗░░░░░░██████╗\r\n╚══██╔══╝██╔══██╗██║██║░░░░░██╔════╝\r\n░░░██║░░░███████║██║██║░░░░░╚█████╗░\r\n░░░██║░░░██╔══██║██║██║░░░░░░╚═══██╗\r\n░░░██║░░░██║░░██║██║███████╗██████╔╝\r\n░░░╚═╝░░░╚═╝░░╚═╝╚═╝╚══════╝╚═════╝░");
    }

    //Checking if correct or wrong
    if (coinFlip == 0 && userGuess == 1) //correct head
    {
        Console.WriteLine("You're correct!");
        userPoints += 1;
        Console.WriteLine("You now currently have " + userPoints + " Points.");
    }
    else if (coinFlip == 0 && userGuess == 2) // wrong tail
    {
        Console.WriteLine("Incorrect! D:");
        userPoints -= 1;
        Console.WriteLine("You now currently have " + userPoints + " Points.");
    }
    if (coinFlip == 1 && userGuess == 2) //correct tail
    {
        Console.WriteLine("You're correct!");
        userPoints += 1;
        Console.WriteLine("You now currently have " + userPoints + " Points.");
    }
    else if (coinFlip == 1 && userGuess == 1) // wrong head
    {
        Console.WriteLine("Incorrect! D:");
        userPoints -= 1;
        Console.WriteLine("You now currently have " + userPoints + " Points.");
    }

    Console.WriteLine("Press Enter to play again!");
    coinFlip = generator.Next(2); //reset game
    Console.ReadLine();
    Console.Clear();

    Console.WriteLine("You currently have: " + userPoints + (" Points"));
    Console.WriteLine("================================= \r\n Would you like to bet on: \r\n 1. Heads \r\n 2. Tails");
    int.TryParse(Console.ReadLine(), out userGuess);

    //make sure input is correct
    while (userGuess < 1 || userGuess > 2)
    {
        Console.WriteLine("!!ERROR!! Please input \" 1 \" or \" 2 \" ");
        Console.WriteLine("Would you like to bet on: \r\n 1. Heads \r\n 2. Tails");
        int.TryParse(Console.ReadLine(), out userGuess);
    }
}
if (userPoints < 0)
{
    Console.WriteLine("\r\n██╗░░░██╗░█████╗░██╗░░░██╗  ██╗░░░░░░█████╗░░██████╗████████╗\r\n╚██╗░██╔╝██╔══██╗██║░░░██║  ██║░░░░░██╔══██╗██╔════╝╚══██╔══╝\r\n░╚████╔╝░██║░░██║██║░░░██║  ██║░░░░░██║░░██║╚█████╗░░░░██║░░░\r\n░░╚██╔╝░░██║░░██║██║░░░██║  ██║░░░░░██║░░██║░╚═══██╗░░░██║░░░\r\n░░░██║░░░╚█████╔╝╚██████╔╝  ███████╗╚█████╔╝██████╔╝░░░██║░░░\r\n░░░╚═╝░░░░╚════╝░░╚═════╝░  ╚══════╝░╚════╝░╚═════╝░░░░╚═╝░░░");
}

Console.ReadLine();
