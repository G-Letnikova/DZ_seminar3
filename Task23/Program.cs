// Задача 23 ввести число n, найти куб от 1 до n

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i=1; i<=n; i++)
Console.Write($"{Math.Pow(i,3)} "); // или Console.Write($"{i*i*i} ");