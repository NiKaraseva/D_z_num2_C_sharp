/* Программа, принимающая на вход трёхзначное число и показывающая 
на выходе вторую цифру этого числа*/

int number = new Random().Next(100, 1000);

int num1 = number % 100;
int num2 = num1 / 10;

Console.WriteLine($"Вторая цифра числа {number} = {num2}");

