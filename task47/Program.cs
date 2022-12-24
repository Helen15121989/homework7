//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


Console.WriteLine("Введите m"); // Запрос у пользователя данные
int  m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int  n = Convert.ToInt32(Console.ReadLine());
double [,] array = GetRealNumbers (m,n);
PrintArray(array); // метод выводим массив на экран





void PrintArray(double[,] array) // метод вывода на экран
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            double number = Math.Round (array [i,j],2);
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

double [,] GetRealNumbers (int m, int n) // метод 

{
    double [,] array = new double [m,n];
    
        Random random = new Random();

        
        for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = new Random().NextDouble() * 30 - 10;
        }
    }

    return array;
}




