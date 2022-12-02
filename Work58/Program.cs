/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/ 

int[,] Generate2DArray(int lengthRow, int lengthCol, int min,int max)
{
      
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i<lengthRow; i++)
    {
        for (int j = 0; j<lengthCol; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Print2dArray(int[,] array)
{
    
    Console.WriteLine();
    
    for (int i = 0; i<array.GetLength(0); i++)
    {
        
        for (int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

        

int [,] MultiplicationOfArrays (int[,] array1, int[,] array2)
{
        
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i<array1.GetLength(0); i++)
    {
        for (int j = 0; j<array2.GetLength(1); j++)
        {
            result[i, j] = 0;

            for (int k = 0; k<array1.GetLength(1); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
}




int[,] generatedArray1 = Generate2DArray(2,2,0,10);
Console.WriteLine("Первый массив:");
Print2dArray(generatedArray1);
Console.WriteLine();
int[,] generatedArray2 = Generate2DArray(2,2,0,10);
Console.WriteLine("Второй массив:");
Print2dArray(generatedArray2);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
Print2dArray(MultiplicationOfArrays(generatedArray1,generatedArray2));
