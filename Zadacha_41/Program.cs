// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();
Console.Write("Введи число М - количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
if(m <0) m *= (-1);

int[] array = new int[m];

for(int i = 0; i < m; i++)
{
    Console.Write($"Введи число {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine($"Количество чисел больше нуля: {PosiniveCount(array)}");

int PosiniveCount(int[] array)
{
    int size = array.Length;
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        if (array[i] > 0) count ++;
    }
    return count;
}