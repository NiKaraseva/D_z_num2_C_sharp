/* Программа, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.*/

// (!) ВАРИАНТ 1 

/* Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

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
}*/ 


// (!) ВАРИАНТ 2 

Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;

int length = number.Length;
if(length < 3)
{
  Console.WriteLine("Третьей цифры нет"); 
}
else 
{
  Console.WriteLine($"Третья цифра {number} = {number[2]}");
}