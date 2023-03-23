using System;
namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            int row1 = 0;
            int col1 = 0;
            int row2 = 0;
            int col2 = 0;
            row1 = Convert.ToInt16(Console.ReadLine());
            col1 = Convert.ToInt16(Console.ReadLine());
            row2 = Convert.ToInt16(Console.ReadLine());
            col2 = Convert.ToInt16(Console.ReadLine());
            double[,] matrix1;
            double[,] matrix2;


            matrix1 = new double[row1, col1];
            Console.WriteLine("enter the numbers");
            for (int i = 0; i < col1; i++)
            {
                for (int j = 0; j < row1; j++)
                {
                    matrix1[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            };



            matrix2 = new double[row2, col2];
            Console.WriteLine("enter the numbers");
            for (int i = 0; i < col2; i++)
            {
                for (int j = 0; j < row2; j++)
                {
                    matrix2[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            };
            int rA = matrix1.GetLength(0);
            int cA = matrix1.GetLength(1);
            int rB = matrix2.GetLength(0);
            int cB = matrix2.GetLength(1);
            double[,] wynik = new double[rA, cB];
            if (cA != rB)
            {
                Console.WriteLine("Matrixes can't be multiplied!");
            }
            else
            {
                double temp = 0;


                for (int i = 0; i < rA; i++)
                {
                    for (int j = 0; j < cB; j++)
                    {
                        temp = 0;
                        for (int k = 0; k < cA; k++)
                        {
                            temp += matrix1[i, k] * matrix2[k, j];
                        }
                        wynik[i, j] = temp;
                        Console.WriteLine(temp);
                    }
                }


            }





        }
    }
}

