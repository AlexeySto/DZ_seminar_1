// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number > 1)
{
   int i = 2;

   Console.Write(number + " -> ");

   while (i < number - 1)
   {
       Console.Write(i + ", ");
       i = i + 2;
   }
   if (number % 2 == 0)
   {
       Console.WriteLine(number);
   }
   else
   {
       Console.WriteLine(number - 1);
   }
}
else
{
    Console.WriteLine("Данное число меньше двойки.");
}