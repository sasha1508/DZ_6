// Задача 42 (необязательно): Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.Clear();
Console.Write("Введи десятичное число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
if(chislo < 0) chislo *= (-1);

System.Console.WriteLine($"Десятичное число {chislo} в двоичной системе счисления: " + Bin(chislo));

string Bin(int chislo)
{
    int temp = 0;
    string chisloBin = "";
    while(chislo > 0)
    {
        temp = chislo % 2;
        if (temp == 1) chisloBin = "1" + chisloBin;
        else chisloBin = "0" + chisloBin;

        chislo /= 2;
    }
    return chisloBin;
}