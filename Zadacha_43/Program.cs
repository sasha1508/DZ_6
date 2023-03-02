// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.Write("Введи число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введи число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введи число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введи число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] dotXY = Dot(b1, k1, b2, k2);

if (dotXY[0] == 1) System.Console.WriteLine("Прямые совпадают");
else if (dotXY[0] == 2) System.Console.WriteLine("Прямые парралельны и не совпадают (не пересекаются)");
else System.Console.WriteLine($"Прямые пересекаются в точке с координатами x = {dotXY[1]}, y = {dotXY[2]}.");

double[] Dot(double b1, double k1, double b2, double k2)
{
    double[] array = new double[3];
    if (k1 == k2)
    {
        if (b1 == b2) array[0] = 1; // Прямые совпадают
        else array[0] = 2; // Прямые парралельны и не совпадают (не пересекаются)    
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        array[1] = x;
        array[2] = y;
    }

    return array;
}