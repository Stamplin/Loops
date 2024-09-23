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

Random generator = new Random();
int diceRoll, Cpoints, Cguess;
Cpoints = 3;
diceRoll = generator.Next(2);
Console.WriteLine("\r\n░███████╗  ░█████╗░░█████╗░██╗███╗░░██╗  ░█████╗░░█████╗░░██████╗██╗███╗░░██╗░█████╗░  ░███████╗\r\n██╔██╔══╝  ██╔══██╗██╔══██╗██║████╗░██║  ██╔══██╗██╔══██╗██╔════╝██║████╗░██║██╔══██╗  ██╔██╔══╝\r\n╚██████╗░  ██║░░╚═╝██║░░██║██║██╔██╗██║  ██║░░╚═╝███████║╚█████╗░██║██╔██╗██║██║░░██║  ╚██████╗░\r\n░╚═██╔██╗  ██║░░██╗██║░░██║██║██║╚████║  ██║░░██╗██╔══██║░╚═══██╗██║██║╚████║██║░░██║  ░╚═██╔██╗\r\n███████╔╝  ╚█████╔╝╚█████╔╝██║██║░╚███║  ╚█████╔╝██║░░██║██████╔╝██║██║░╚███║╚█████╔╝  ███████╔╝\r\n╚══════╝░  ░╚════╝░░╚════╝░╚═╝╚═╝░░╚══╝  ░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝╚═╝░░╚══╝░╚════╝░  ╚══════╝░");
Console.WriteLine("================================= \r\n Welcome to the Coin Casino Game!");
Console.WriteLine("================================= \r\n How to play: You will choose heads or tail, If you guessed correctly, you win a point, \r\n however if you chose incorrectly, you lose a point.");
Console.WriteLine("================================= \r\n You currently have: " + Cpoints + (" Points"));
Console.WriteLine("================================= \r\n Would you like to bet on: \r\n 1. Heads \r\n 2. Tails");
int.TryParse(Console.ReadLine(), out Cguess);
//make sure input is correct
while (Cguess >= 1 || Cguess <= 2 )
{
    Console.WriteLine("!!ERROR!! Please input \" 1 \" or \" 2 \" ");
    Console.WriteLine("Would you like to bet on: \r\n 1. Heads \r\n 2. Tails");
    int.TryParse(Console.ReadLine(), out Cguess);
}


if (diceRoll == 0 && Cguess == 1) //head
{
    Console.WriteLine("it is Heads! You're correct!");  
    Cpoints += 1;
}


if (diceRoll == 1) //tail
{
    Console.WriteLine("Tails");
    Cpoints += 1;
}


Console.ReadLine();
