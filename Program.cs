using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] originalMatrix = new int[3, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };

        int[,] modifidedMatrix = new int[originalMatrix.GetLength(0), originalMatrix.GetLength(1)];

        for (int i = 0; i < originalMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < originalMatrix.GetLength(1); j++)
            {
                if (j < i)
                {
                    modifidedMatrix[i, j] = 0;
                }
                else if (j > i)
                {
                    modifidedMatrix[i, j] = 1;
                }
                else
                {
                    modifidedMatrix[i, j] = originalMatrix[i, j];
                    modifidedMatrix[i, j] = originalMatrix[i, j];
                }
            }
        }

        Console.WriteLine("Original Matrix: ");
        for (int i = 0; i< originalMatrix.GetLength(0); i++)
        {
            for (int j = 0;j < originalMatrix.GetLength(1); j++) 
            {
                Console.Write(originalMatrix[i, j] + "   ");
            }
            Console.WriteLine();            
        }

        Console.WriteLine("Result Matrix: ");
        for (int i = 0; i < modifidedMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < modifidedMatrix.GetLength(1); j++)
            {
                Console.Write(modifidedMatrix[i, j] + "   ");
            }
            Console.WriteLine();
        }

    }
}