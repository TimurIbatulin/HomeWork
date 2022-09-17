//напишите программу, которая на вход принемает два числа и выдает какое число больше, а какое меньше 
//Console.Write("Введите первое число - ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число - ");
//int b = Convert.ToInt32(Console.ReadLine());
//if (a > b)
//{
//    Console.WriteLine("max="+a);
//}
//else
//{
//     Console.WriteLine("max="+b);
//}


//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.Write("Введите первое число - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число - ");
int c = Convert.ToInt32(Console.ReadLine());
int d = 0;
if (a > b)
{
d = a;
}
else
{
    d = b;
}
if (d > c)
{
    Console.WriteLine("Максимальное из трех чисел - " + d);
}
else
{
     Console.WriteLine("Максимальное из трех чисел - " + c);
}