Console.Clear(); 
Console.Write("Введите числа через пробел: "); 
string[] n = Console.ReadLine().Split(" "); 
int count = 0; 
foreach (string i in n) 
{ 
          if (int.Parse(i) > 0) 
          count++; 
} 
Console.WriteLine(count); 
