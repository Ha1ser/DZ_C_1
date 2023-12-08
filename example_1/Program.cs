// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n % 7 == 0 && n % 23 == 0) {Console.WriteLine("кратно ОГОНЬ:)");}
else {Console.WriteLine("Не кратно :(");}
