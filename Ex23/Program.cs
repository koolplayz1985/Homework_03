﻿// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); //Пользователь задаёт переменнную (число) с котором будет работать метод

void TableCubes(int numMax) //Тип данных void/название метода TableCubes/
{
    int num = 1;           //переменная (число) с которого начинается отсчёт в таблице (задана цифра 1)
    while (num <= numMax)  //пока numMax (переменная заданная пользователем) больше или равна num (задана цифра 1)
    {
        Console.WriteLine($"{n} --> | {num} | {num * num * num}   |"); //выводим n (переменная заданная пользователем)
        num++;
    }
}

TableCubes(n);