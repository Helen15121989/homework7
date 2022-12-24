/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/



int [,] array = new int [5,3];
PrintRandom(array); // Вывод -метод рандомного массива 
PrintArray(array); // Вывод - метод массив на экран




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
void PrintRandom (int [,] array) // метод заполняем массив рандомными числами

{
    
    Random random = new Random();


    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)


        {
            array[i, j] = random.Next(10, 100);

        }

    }
    

}

Console.WriteLine("Введите индекс строки: "); // Запрос у пользователя данные
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int column = Convert.ToInt32(Console.ReadLine());


void GetElement()
{
    if (line< array.GetLength(0) && column < array.GetLength(1))
{
    Console.WriteLine (array [line,column]);
}
else 
{
    Console.WriteLine ("Такого числа в массиве нет");
}
}
GetElement();
