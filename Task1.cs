Console.WriteLine("Большее и меньшее");
// Console.Write("Напишите первое число: ");
int first = int.Parse(Console.ReadLine()!);
Console.Write("Напишите второе число: ");
int second = int.Parse(Console.ReadLine()!);
if (first < second)
{
    Console.WriteLine("Первое меньше второго");
}
else if(first > second)
{
    Console.WriteLine("Первое больше второго");
}
else
{
    Console.WriteLine("Они равны");
}