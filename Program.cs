//Задача 2
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

//Задача 4
int c;
int max;
Console.WriteLine("Введите число a:");
a = Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("Введите число b:");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c:");
c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
     max=a;
}
else
{
max=b;
}
if (max>c)
{
    Console.WriteLine($"число {max} больше");
}
else 
{
    Console.WriteLine($"число {c} больше");
}
//задача 6
Console.WriteLine("Введите число чет/нечет:");
a = Convert.ToInt32(Console.ReadLine()) ;
b = a%2;
if (b>0)
{
   Console.WriteLine("нечетное"); 
}
else 
{
  Console.WriteLine("четное");   
}

//Задача 8
Console.WriteLine("Введите N:");
a = Convert.ToInt32(Console.ReadLine()) ;
b = 2;
while (a>=b)
{
    Console.Write($"{b}, ");
    b = b + 2;
} 
Console.WriteLine(" ");