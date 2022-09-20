/* Программа, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.*/

Console.WriteLine("Введите цифру от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

int mon = 1;
int tsd = 2;
int wd = 3;
int thd = 4;
int frd = 5; 
int std = 6;
int snd = 7;

if ((number == mon) || (number == tsd) || (number == wd) || (number == thd) || (number == frd))
{
    Console.WriteLine("День НЕ является выходным");
}
else if ((number == std) || (number == snd))
{
    Console.WriteLine("День является выходным");
}

else
{
    Console.WriteLine("Вы ввели число, которое не является днём недели");
}