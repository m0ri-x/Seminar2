﻿// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine("Случайное число " + number);

int digit1 = number / 100;
int digit2 = number % 10;

int result = 10 * digit1 + digit2;
Console.WriteLine(result);