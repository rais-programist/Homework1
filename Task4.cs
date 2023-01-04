Console.WriteLine("Все четные числа до данного");
Console.WriteLine("Напишите любое число: ");
int N = int.Parse(Console.ReadLine()!);
if(N <= 0)
{
    Console.WriteLine("Число не может быть отрицательным!");
}
for(int i = 2; i <= N; i = i+2)
    {
        Console.WriteLine(i);
    }