int a, b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a%b == 0) Console.WriteLine("кратно");
else
{
    Console.Write("некратно, остаток ");
    Console.WriteLine(a%b);
}
