﻿// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int Prompt(string message)

{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобразует строку в целое число
    return result;                          // Возвращает результат
}

int num = Prompt("Введите число ");
if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine($"Число {num} кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"Число {num} не кратно 7 и 23");
}
