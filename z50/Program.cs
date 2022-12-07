// Задача 50. Напишите программу, которая на вход принимает 
// индексы элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 3 -> 3


void Zadacha50()
{

    Console.WriteLine("Введите массив");
    int[,] array = new int[4, 5];
    FillArray(array, -5, 10);
    PrintArray(array);
    FindElement(array,2,4);
}


// Описание методов
void FillArray(int[,] massive, int min, int max)
{
    max++;
    Random rand = new Random();
    int rows = massive.GetLength(0);
    int columns = massive.GetLength(1);

    for (int i = 0; i < rows; i++)
    {

        for (int j = 0; j < columns; j++)
        {
            massive[i, j] = rand.Next(min, max);

        }


    }

}


void PrintArray(int[,] massive)
{
    int rows = massive.GetLength(0);
    int columns = massive.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++) Console.Write(massive[i, j] + "\t");

        Console.WriteLine();
    }
}
void FindElement(int[,] massive, int x, int y)
{
    Console.WriteLine("Введите индекс элемента в массиве");
    if (x < 4 && y < 5) Console.WriteLine("Значение элемента > " + massive[x, y]);
    else Console.WriteLine("элементов с таким индексом в массиве нету");
}

Zadacha50();