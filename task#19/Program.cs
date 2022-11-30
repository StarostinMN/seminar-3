/* Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом: 14212 -> нет, 12821 -> да, 23432 -> да*/
Console.Clear();
Console.WriteLine("Введите целое число");
int Number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int varNumber = Number;
int countNumber = 0;
while (varNumber > 0)
{
    varNumber = (int)(varNumber / 10);
    countNumber = countNumber + 1;
}
if (countNumber < 2)
{
    Console.WriteLine("Вы ввели однозначное число, повторите ввод");
}
else
{
    int i = 1;
    varNumber = Number;
    while (i <= (int)(countNumber / 2))
    {
        //Console.Write($"i={i}: ");
        int highDigit = (int)(varNumber / Math.Pow(10, (countNumber - i)));
        //Console.Write($"{highDigit}, ");
        int lowDigit = (int)(varNumber % Math.Pow(10, i) / Math.Pow(10, i - 1));
        //Console.Write($"{lowDigit};  ");
        varNumber = (int)(varNumber - highDigit * Math.Pow(10, (countNumber - i)) - lowDigit);

        if (highDigit != lowDigit)
        {
            Console.WriteLine("Введенное число не является палиндромом");
            i = countNumber;
        }
        else
        {
            if (i == ((int)(countNumber / 2)))
            {
                Console.WriteLine("Введенное число является палиндромом");
            }
            i = i + 1;
        }
    }
}


