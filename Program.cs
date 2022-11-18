using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Enter matrix size, through a space (for example: 4 5): ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    int[,] array = GetArray(Convert.ToInt32(nums[0]),Convert.ToInt32(nums[1]));

    PrintArray(array);

}
catch
{
    Write("Error run!");
}

int[,] GetArray(int rows, int colums)
{
    int[,] result = new int[rows, colums];
    int i = 0, j = 0;
    int number = 1;
    
    int minX = 0;
    int minY = 0;
    int maxX = result.GetLength(0);
    int maxY = result.GetLength(1);
    while (minX < maxX)
    {
        while (j < maxY)
        {
            result[i, j] = number;
            number++;
            j++;
        }
        j--;
        i++;
        while (i < maxX)
        {
            result[i, j] = number;
            number++;
            i++;
        }
        i--;
        j--;
        while (j >= minY)
        {
            result[i, j] = number;
            number++;
            j--;
        }
        i--;
        j++;
        while (i > minY)
        {
            result[i, j] = number;
            number++;
            i--;
        }
        i++;
        j++;
        minX++;
        minY++;
        maxX--;
        maxY--;
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j].ToString().PadLeft(5, ' ')} ");
        }
        WriteLine();
    }
}

