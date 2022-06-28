int a, b, x, y;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(a / b);
x = Convert.ToInt32(a - b * (a / b));
if (b * y == a) Console.WriteLine("кратно");
else
{
    Console.Write("некратно, остаток ");
    Console.WriteLine(x);
}
