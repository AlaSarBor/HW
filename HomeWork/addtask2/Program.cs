int num = Convert.ToInt32(Console.ReadLine()!);
string text = Convert.ToString(num);
if (text.Length > 2)
{
    Console.WriteLine("третья цифра -> " + text[2]);
}
else
{
    Console.WriteLine("-");
}