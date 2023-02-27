using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    public class Matrix
    {
        private double[,] matrix;
        int Row = 0, Col = 0;

        public Matrix(int row, int col)
        {
            matrix = new double[row, col];
            Row = row; Col = col;
        }

        public Matrix(int N)
        {
            matrix = new double[N, N];
            Row = Col = N;
        }
        public double this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }
        public static Matrix operator +(Matrix first, Matrix second)
        {
            Matrix mat = new Matrix(first.Row, first.Col);
            for (int i = 0; i < first.Row; i++)
                for (int j = 0; j < first.Col; j++)
                    mat[i, j] = first[i, j] + second[i, j];
            return mat;
        }
        public static Matrix operator -(Matrix first, Matrix second)
        {
            Matrix mat = new Matrix(first.Row, first.Col);
            for (int i = 0; i < first.Row; i++)
                for (int j = 0; j < first.Col; j++)
                    mat[i, j] = first[i, j] - second[i, j];
            return mat;
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                    Console.Write("{0}  ", this[i, j]);
                Console.Write("\n");
            }

        }
    }
}
