int a;
Console.Write("Введите число ");
a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0){
    if (a % 23 == 0) Console.WriteLine("кратно");
}
else Console.Write("некратно");
