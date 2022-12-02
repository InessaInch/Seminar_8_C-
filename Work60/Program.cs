/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/ 

int[,,] Generate3DArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            for (int k = 0; k<array.GetLength(2); k++)
            {
                array[i,j,k] += count;
                count += 3;
            }
        }
    }
    return array;
}

void Print3dArray(int[,,] array)
{
    
    Console.WriteLine();
    
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            for (int k = 0; k<array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }

}

int[,,] array3D = new int[2, 2, 2];
Generate3DArray(array3D);
Console.WriteLine("Трёхмерный массив из неповторяющихся двузначных чисел: ");
Print3dArray(array3D);
        

