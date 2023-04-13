using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] originalMatrix = new int[3, 3] { { 1, 2, 4 }, { 2, 3, 4 }, { 2, 4, 100 } };

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
                }
            }
        }
    }
}