//напишите программу, которая на вход принемает два числа и выдает какое число больше, а какое меньше 
Console.Write("Введите первое число - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("max="+a);
}
else
{
     Console.WriteLine("max="+b);
}