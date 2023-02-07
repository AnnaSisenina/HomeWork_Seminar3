// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите натуральное число: ");
int N=int.Parse(Console.ReadLine() ?? "0");
long multipl=1;
if (N<1) Console.WriteLine("Вы ввели ненатуральное число");
else
{
    for (int i=1; i<=N; i++) 
    multipl=multipl*i;
    Console.WriteLine($"Произведение чисел от 1 до {N} равно {multipl}");
}
