// Задача 19 ввести положительное число n, вывести является ли оно палиндромом
// задача на массивы

Console.Clear();
Console.Write("Введите число: ");
string str = Console.ReadLine();
int n = Convert.ToInt32(str.Length);
int i = 0;

while (str[i] == str[n-1-i] && i<n/2)
{ i++; }

if (i<n/2) Console.WriteLine($"Число {str} не палиндром");
else Console.WriteLine($"Число {str} палиндром");
 