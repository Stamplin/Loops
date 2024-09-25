//task1

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i + ". Icecream");
}

//task2

int countTothis;
Console.WriteLine("what do you want me to count to?");
int.TryParse(Console.ReadLine(), out countTothis);
for (int i = 0; i <= countTothis; i++)
{
    Console.WriteLine(i);
}

//task 3

int countFrom, countTo, countBy;
Console.WriteLine("input the number you want to count to: ");
int.TryParse(Console.ReadLine(), out countTo);
Console.WriteLine("input the number you want to count from: ");
int.TryParse(Console.ReadLine(), out countFrom);
Console.WriteLine("input the number you want to count by: ");
int.TryParse(Console.ReadLine(), out countBy);

if (countBy > 0)
{
    for (int i = countTo; i <= countFrom; i += countBy)
    {
        Console.WriteLine(i);
    }
}

Programming Assignments

task1 countingdown

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
    
}
Console.WriteLine("Blast off!");
