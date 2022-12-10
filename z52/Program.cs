// Задача 52. Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 5 3
// 8 4 6 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.


void Zadacha52()
{
    Random rand = new Random();
    Console.WriteLine("Введите массив");
    int[,] array = new int[4, 5];
    FillArray(array, -5, 10);
    PrintArray(array);
    ArithmeticMean(array);
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
        
        for (int j = 0; j < columns;j++)
        {
            massive[i,j]= rand.Next(min,max);

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



void ArithmeticMean(int[,] massive)
{
    int rows = massive.GetLength(0);
    int columns = massive.GetLength(1);
      int count =0;
    for (int i = 0; i < columns; i++)
    { 
        double sred = 0;
        for (int j = 0; j < rows; j++) 
        {
        sred+=massive[j, i];
        count ++;
        }
        Console.WriteLine($"индекс колонки > {i}, среднее арифмитическое {Math.Round(sred / count,1)}");
    }

}


Zadacha52();