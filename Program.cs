﻿Console.WriteLine("Введите трёх значное число");
int a = Convert.ToInt32(Console.ReadLine());
//int n1 = a / 100;
int n2 = (a % 100) / 10;
//int n3 = (a % 100) % 10;
Console.WriteLine("Второе число = ");
Console.Write(n2);