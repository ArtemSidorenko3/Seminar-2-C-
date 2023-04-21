//Задача 13.  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

    while (number > 999)
    number = number / 10;
    { 
       if(number < 100)
       {
        Console.Write("Третьей цифры нет.");
        return;
       }
       else
       {
        int result = number % 10;
        Console.WriteLine($"{result}");
       }
    }
