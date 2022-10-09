// See https://aka.ms/new-console-template for more information
int a = 0;
int b = 0;

Console.WriteLine("Введите число a:");

a = Convert.ToInt32(Console.ReadLine()) ;
Console.WriteLine("Введите число b:");

b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
     Console.WriteLine($"число {a} больше");
}
else Console.WriteLine($"число {b} больше");