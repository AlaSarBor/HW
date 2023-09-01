int numA = Convert.ToInt32(Console.ReadLine()!);
int numB = Convert.ToInt32(Console.ReadLine()!);
if (numA < numB)
{
    Console.Write($"min= {numA}, max= {numB}");
}
else if (numA > numB)
{
    Console.Write($"min= {numB}, max= {numA}");
}
else
{
    System.Console.WriteLine("числа равны");
}

