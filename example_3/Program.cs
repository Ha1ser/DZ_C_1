int r = new Random().Next(10, 99);

int p1 = r / 10; //Первое число
int p2 = r % 10; // последние число

Console.WriteLine("рандомные число: " + r);
Console.Write("Наибольшее из них : ");
if (p1 > p2) {Console.WriteLine(p1);}
else {Console.WriteLine(p2);}


