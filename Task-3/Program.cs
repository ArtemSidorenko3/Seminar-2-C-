// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");

int day = int.Parse(Console.ReadLine());
if ( 1 <= day && day <= 7)
{
    if(6 == day || day == 7)
    {
        Console.WriteLine("ДА. Это выходной день!");
    }
    else
    {
        Console.WriteLine("Нет. Сегодня будний день.");
    }
}
else
{
    Console.WriteLine("В неделе семь дней.");
}
