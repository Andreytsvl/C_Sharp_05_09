// See https://aka.ms/new-console-template for more information
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
Clear();
Write("Введите число a: ");
int a = int.Parse(ReadLine());
Write("Введите число b: ");
int b = int.Parse(ReadLine());
float c = a % b;
if (c==0)
    {
        Write("кратно");
        
    }    
    else
    {
        Write($"не кратно, остаток {c}");
    }

// task12
