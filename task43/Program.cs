﻿Console.Clear(); 
Console.Write("Введите k1 и b1 : "); 
string[] numbersFirst = Console.ReadLine().Split(" "); 
double k1 = double.Parse(numbersFirst[0]); 
double b1 = double.Parse(numbersFirst[1]); 
Console.Write("Введите k2 и b2 : "); 
string[] numbersSecond = Console.ReadLine().Split(" "); 
double k2 = double.Parse(numbersSecond[0]); 
double b2 = double.Parse(numbersSecond[1]); 
Console.WriteLine((b2 - b1) / (k1 - k2)); 
Console.WriteLine(k2 * (b2 - b1) / (k1 - k2) + b2); 
