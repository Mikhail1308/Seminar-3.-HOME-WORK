// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

int total = 0;
int t = 0;
int revers = 0;
Console.WriteLine("Введите пятизначное число = ");
int num = int.Parse(Console.ReadLine());
t = num;
while (num > 0)
{
    revers = num % 10;
    total = (total * 10) + revers;
    num = num / 10;
}
if (t == total) Console.Write("Данное число - палиндром");
else Console.WriteLine("Данное число не является палиндромом");
System.Console.WriteLine();
