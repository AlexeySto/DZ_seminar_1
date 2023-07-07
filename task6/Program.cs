// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите первое число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 1 || number % 2 == -1)
{
    Console.WriteLine(number + "-> нечетное");
}
else
{
    Console.WriteLine(number + "-> четное");
}