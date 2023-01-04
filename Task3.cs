Console.WriteLine("Является ли число трехзначным");
Console.WriteLine("Введите любое число: ");
int num = int.Parse(Console.ReadLine()!);

if(num == 0)
{
    Console.WriteLine("Число равно нулю");
}
else if(num%2 == 0)
{
    Console.WriteLine("Число четное!");
}
else
{
    Console.WriteLine("Число нечетное!");
}