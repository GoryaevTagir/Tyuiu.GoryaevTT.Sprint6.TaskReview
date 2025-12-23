namespace Tyuiu.GoryaevTT.Sprint6.TaskReview.Lib
{
    public class DataService
    {
        public int[,] array;
        public int result_GetMatrix(int[,] matrix,int n1, int n2, int c, int k, int l )
        {
            Random rn = new Random();
            int sum = 0;
            for (int r = 0;r < matrix.GetLength(0); r++)
            {
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    if (r == 0)
                    {
                        matrix[r, b] = rn.Next(n1, n2);
                    }
                    else
                    {
                        matrix[r, b] = rn.Next(n1, n2);
                        if ((matrix[r - 1, b] % 2 == 0 && matrix[r, b] % 2 == 0) || matrix[r - 1, b] % 2 != 0 && matrix[r, b] % 2 != 0)
                        {
                            matrix[r, b] = matrix[r,b] - 1;
                        }
                    }
                }
            }
            for (int j = k; j <= l; j++)
            {
                if (matrix[c, j] % 2 == 0)
                {
                    sum += matrix[c, j];
                }
            }
            array = matrix;
            return sum;
        }
    }

}
