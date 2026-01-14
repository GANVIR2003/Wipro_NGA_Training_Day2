// See https://aka.ms/new-console-template for more information
using System;

int[,] matrix = new int[3, 3]
{
    {1,2,3 },
    {4,5,6 },
    {7,8,9 }

};

for(int i=0; i<3; i++)
{
    for(int j=0; j<3; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

//jagged arrys in C# 
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] { 1, 2 };
jaggedArray[1] = new int[] { 3, 4, 5 };
jaggedArray[2] = new int[] { 6, 7, 8, 9 };

for (int i=0;  i<jaggedArray.Length; i++)
{
    for(int j=0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}
//Showing memory efficiency of Jagged Arrays over 20 arrays

Console.WriteLine("Memory Efficiency Comparison:");

int totalElements2D = 3 * 3; // 20 array with 3 rows and 3 columns

int totalElementsJagged = 2 + 3 + 4; // Jagged array with rows of sizes 2, 3, and 4

for (int i = 0; i < totalElements2D; i++)
{
    Console.Write("*");
    Console.Write(totalElements2D > totalElementsJagged ? "" : "");
}// Representing memory usage for 2D array

Console.WriteLine(" <- 2D Array Memory Usage");
int bytesPerElement = Buffer.ByteLength(new int[1]);
Console.WriteLine("total memory in bytes taken by 2 D array " + bytesPerElement);


for (int i = 0; i < totalElementsJagged; i++)
{ 
Console.Write("*");
    Console.Write(totalElements2D > totalElementsJagged ? "" : "");// Representing memory usage for Jagged array
}
Console.WriteLine(" <- Jagged Array Memory Usage");
Console.WriteLine("total memory in byte taken by Jagged array" + (bytesPerElement * totalElementsJagged));

//In this example, the jagged array uses less memory than the 2D array due to its non-uniform row sizes.
