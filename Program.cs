﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int[] arr = new int [5];
// arr[0]=5;
// arr[1]=8;
// arr[2]=40;
// arr[3]=2;
// arr[4]=5;
// Console.WriteLine(arr[0]);
// Console.WriteLine(arr[2]);
// Console.WriteLine(arr[3]);
// int[] arr1 = {1,2,3,4,5};
// Console.WriteLine(arr1[0]);
// Console.WriteLine(arr1[2]);
// Console.WriteLine(arr1[4]);

// task9
using System;
using static System.Console;

// Clear();
// int  number = new Random().Next(10,100);
// int a1 = number/10;
// int a2 = number%10;
// if(a1>a2)
// {
//     WriteLine($"{number}->{a1}");
// }
// else
// {
//     WriteLine($"{number}->{a2}");
// }

// task11
// Clear();
// int  number = new Random().Next(100,1000);
// int a1 = number/100;
// int a2 = number/10; //ненужная строка
// int a3 = number%10;
// WriteLine($"{number}->{a1*10+a3}");

// task12
// Clear();
// Write("Введите число a: ");
// int a = int.Parse(ReadLine());
// Write("Введите число b: ");
// int b = int.Parse(ReadLine());
// float c = a % b;
// if (c==0)
//     {
//         Write("кратно");

//     }    
//     else
//     {
//         Write($"не кратно, остаток {c}");
//     }

// task14
// Clear();
// Write("Введите число a: ");
// int a = int.Parse(ReadLine());
// if ((a % 7 == 0) & (a % 23 == 0))
// {
//     Write("да");
// }
// else
// {
//     Write("нет");
// }

// task16
// Clear();
// Write("Введите число a: ");
// int a = int.Parse(ReadLine());
// Write("Введите число b: ");
// int b = int.Parse(ReadLine());
// if (a * a == b)
// {
//     Write("b квадрат a");
// }
// else
// {
//     if (b * b == a)
//     {
//         Write("a квадрат b");
//     }
//     else
//     {
//         Write("не является");
//     }
// }

// task10_DZ
// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// Clear();
// Write("Введите трёхзначное число a: ");
// int a = int.Parse(ReadLine());
// float b2 = ((a % 100) - (a % 10)) / 10;
// Write($"{a}->{b2}");

// task13_DZ
// Задача 13: Напишите программу, которая выводит
//  третью цифру заданного числа
//  или сообщает, что третьей цифры нет.
// Clear();
// Write("Введите число a: ");
// int a = int.Parse(ReadLine());
// if (a < 100)
// {
//     WriteLine("третьей цифры нет");
//     return;
// }
// else
// {
//     WriteLine($"{a}->{((a % 1000)-(a % 100)) / 100}");
//     (a/100)%10; второй вариант
// }

// task15_DZ
// Задача 15: Напишите программу, 
// которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.
// Clear();
// Write("Введите цифру, обозначающую день недели : ");
// int a = int.Parse(ReadLine());
// if ((a < 1)|| (a > 7))
// {
//     WriteLine("ошибка ввода");
//     return;
// }
// if (5 < a)
// {
//     WriteLine("да");
// }
// else
// {
//     WriteLine("нет");
// }

// task17
// Clear();
// Write("Введите координату х, не равную нулю: ");
// int x = int.Parse(ReadLine());
// Write("Введите координату y, не равную нулю: ");
// int y = int.Parse(ReadLine());
// if ((x == 0) || (y == 0))
// {
//     WriteLine("ошибка ввода");
//     return;
// }
// if ((x > 0) & (y > 0))
// {
//     WriteLine("первая четверть");
//     return;
// }
// if ((x < 0) & (y > 0))
// {
//     WriteLine("вторая четверть");
//     return;
// }
// if ((x < 0) & (y < 0))
// {
//     WriteLine("третья четверть");
//     return;
// }
// else
// {
//     WriteLine("четвёртая четверть");
// }

// task18
// Clear();
// Write("Введите номер координатной четверти от 1 до 4: ");
// int a = int.Parse(ReadLine());
// if ((a < 1)|| (a > 4))
// {
//     WriteLine("ошибка ввода");
//     return;
// }
// if (a==1)
// {
//     WriteLine("x>0; y>0");
//     return;
// }
// if (a==2)
// {
//     WriteLine("x<0; y>0");
//     return;
// }
// if (a==3)
// {
//     WriteLine("x<0; y<0");
//     return;
// }
// else
// {
//     WriteLine("x>0; y<0");
// }

// task20
// Clear();
// Write("Введите координату первой точки х1: ");
// int x1 = int.Parse(ReadLine());
// Write("Введите координату первой точки y1: ");
// int y1 = int.Parse(ReadLine());
// Write("Введите координату второй точки х2: ");
// int x2 = int.Parse(ReadLine());
// Write("Введите координату второй точки y2: ");
// int y2 = int.Parse(ReadLine());
// double d = Math.Pow(((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2)),0.5);
// Write($"Расстояние между точками: {d:f4}");

// task22
Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
int i = 1;
while (i <= a)
{
    Console.Write($"{i * i} ");
    i = i + 1;
}
