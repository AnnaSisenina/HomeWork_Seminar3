// Показать кубы чисел, заканчивающихся на четную цифру
int Cube (int number)
{
int result = number*number*number;
return result;
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Кубы чисел от 0 до {N}, заканчивающиеся на четную цифру: ");

if (N>=0)
{
    for (int count=0; count<=N; count++)
        if (Cube(count)%2==0) Console.WriteLine(Cube(count));
}       
else
{
    for (int count=0; count>=N; count--)
        if ((Cube(count))%2==0) Console.WriteLine(Cube(count));
}