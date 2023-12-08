Console.WriteLine("Введите число 1: ");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int Y = int.Parse(Console.ReadLine());

if (X != 0 && Y != 0) {
    if (X > 0 && Y > 0) {Console.WriteLine("1 четверть");}
    if (X < 0 && Y > 0) {Console.WriteLine("2 четверть");}
    if (X < 0 && Y < 0) {Console.WriteLine("3 четверть");}
    if (X > 0 && Y < 0) {Console.WriteLine("4 четверть");}
    
}else {Console.WriteLine("Число не должно равняться 0");}