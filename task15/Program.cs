// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
    {
        Console.WriteLine("Не выходной");
    }
    
if (number == 2)
    {
        Console.WriteLine("Не выходной");
    }
    
if (number == 3)
    {
        Console.WriteLine("Не выходной");
    }
    
if (number == 4)
    {
        Console.WriteLine("Не выходной");
    }
    
if (number == 5)
    {
        Console.WriteLine("Не выходной");
    }
 
 if (number == 6)
    {
        Console.WriteLine("Выходной");
    }
    
if (number == 7)
    {
        Console.WriteLine("Выходной");
    }

if (number > 7)
    {
        Console.WriteLine("Такого дня не существует");
    }