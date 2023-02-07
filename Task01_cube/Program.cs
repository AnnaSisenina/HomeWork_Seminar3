// Найти кубы чисел от 1 до N
Console.Write("Введите натуральное число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
if (N<1) Console.WriteLine("Вы ввели ненатуральное число");
for (int count=1; count<=N; count++)
Console.WriteLine($"{count}^3={count*count*count}");
