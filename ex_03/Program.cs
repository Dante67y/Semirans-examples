int a, b;
Console.Write("Введите первое число ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0) Console.WriteLine("кратно");
else
{
    Console.Write("некратно, остаток ");
    Console.WriteLine(a % b);
}
