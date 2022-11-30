/* Напишите программу, которая принимает на вход 2 числа (N,M) и выдаёт таблицу кубов чисел от N до M: 2,3 -> 8, 27, 1,5 -> 1, 8, 27, 64, 125. */
Console.Clear();
Console.Write("Введите первое число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int M = Convert.ToInt32(Console.ReadLine());
int count, max;
if (N > M)
{
    count = M;
    max = N;
}
else
{
    count = N;
    max = M;
}
while (count < max)
{
    double cubing = Math.Pow(count, 3);
    Console.Write($"{cubing}, ");
    count = count + 1;
}
Console.WriteLine($"{Math.Pow(max, 3)}.");
