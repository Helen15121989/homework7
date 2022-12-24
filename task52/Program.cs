/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("Введите m"); // Запрос у пользователя данные
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = PrintRandom(m, n); // Вывод -метод рандомного массива 
PrintArray(array); // Вывод - метод массив на экран
GetArithmetic(); // вызов метод среднее арифмитическое




void PrintArray(int[,] array) // метод (вывода на экран)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] PrintRandom(int m, int n) // метод заполняем массив рандомными числами

{
    int[,] array = new int[m, n];
    Random random = new Random();


    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)


        {
            array[i, j] = random.Next(1, 10);

        }

    }
    return (array);

}

 void GetArithmetic ()  // метод среднее арифмитическое
 {
for (int j = 0; j < array.GetLength(1); j++)
{
  double sum = 0;
 for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum +  array [i, j];
    }
    
    
    Console.Write($"{ sum / array.GetLength(0)} ");
}
}




