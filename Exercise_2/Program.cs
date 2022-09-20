/* Программа, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number >= 100)
{
    while (number > 999)
    {
        number = number / 10;
    }
    Console.WriteLine($"Третья цифра заданного числа {number % 10}");
}

if (number < 100)
{
  Console.WriteLine("Третьей цифры нет");  
}
