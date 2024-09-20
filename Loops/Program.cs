//guessing game one
Random generator = new Random();
int spesNUM = generator.Next(11);
int entry;

Console.WriteLine("Guess da number");
Console.WriteLine("WHAT U THINK IS IT??");
int.TryParse(Console.ReadLine(), out entry);
Console.WriteLine();

while (entry != spesNUM)
{
    Console.WriteLine("Incorrect num. Try again!");
    Console.WriteLine("what ya guess the num is?");
    int.TryParse(Console.ReadLine(), out entry);
    Console.WriteLine();
}
Console.WriteLine("correct! it is " + spesNUM);
Console.ReadLine();

//dice game two
int dice1, dice2;
dice1 = generator.Next(7);
dice2 = generator.Next(7);
while  (dice1 != dice2)
{
    dice1 = generator.Next(7);
    dice2 = generator.Next(7);
}
Console.WriteLine(dice1); Console.WriteLine(dice2);
