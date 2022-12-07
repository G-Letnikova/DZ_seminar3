// Dop ______________________________________________
// кусты по кругу, кустов минимум 3, выводим максимальное кол-во ягод и
// позицию, с которой надо стартовать

Console.Clear();
Console.Write("Введите число кустов: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n<3)
{
    Console.WriteLine("Кустов должно быть не менее 3");
    Console.Write("Введите число кустов: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int []berries = new int[n];
for (int b=0; b<n; b++)
{
Console.Write($"Введите число ягод на кусте {b+1}: ");
berries[b] = Convert.ToInt32(Console.ReadLine());
}
int j = 0;         //  куст предыдущий
int k = 0;         //  куст последующий
int sum = 0; 
int position = 0;      
for (int i = 0; i<n; i++)
{
    j = i-1;
    if (j == -1) j = n-1;
    k = i+1;
    if (k == n) k = 0;
    if (sum < berries[j] + berries[i] + berries[k]) 
    {
        sum = (berries[j] + berries[i] + berries[k]);
        position = i;   // самая выгодная позиция
    }
}
Console.WriteLine($"За один подход можно собрать максимум {sum} ягод, начиная с куста {position+1}"); 