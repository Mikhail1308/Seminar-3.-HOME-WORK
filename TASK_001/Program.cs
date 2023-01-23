// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.


Console.WriteLine("Введите пятизначное число = ");
int number = int.Parse(Console.ReadLine());
int pal = 0, num = number;
while (number > 0) { pal = pal * 10 + number % 10; number /= 10; }
Console.WriteLine(num == pal ? "палиндром" : "не палиндром");
System.Console.WriteLine();
