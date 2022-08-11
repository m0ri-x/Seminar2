// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int digitIndex = 2;

if (number[0] == '-')
{
    digitIndex++;
}

if (number.Length <= digitIndex)
{
    Console.WriteLine("Третьей цифры нет");
}

else
{
    Console.WriteLine($"третья цифра {number[digitIndex]} ");
}