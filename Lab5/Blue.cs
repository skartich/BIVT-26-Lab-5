using System.Linq;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class Blue
    {
        public double[] Task1(int[,] matrix)
        {
            double[] answer = null;

            // code here
            int a = matrix.GetLength(0);
            int b = matrix.GetLength(1);
            answer = new double[a];
            for (int i = 0; i < a; i++)
            {
                double s = 0;
                int cnt = 0;
                for (int j = 0; j < b; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        s += matrix[i, j];
                        cnt++;
                    }
                }
                if (cnt > 0)
                {
                    answer[i] = s / cnt;
                }
                else
                {
                    answer[i] = 0;
                }
            }
            // end

            return answer;
        }
        public int[,] Task2(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            int a = matrix.GetLength(0);
            int b = matrix.GetLength(1);
            int mxI = 0;
            int mxJ = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (matrix[i, j] > matrix[mxI, mxJ])
                    {
                        mxI = i;
                        mxJ = j;
                    }
                }
            }
            answer = new int[a - 1, b - 1];
            int ni = 0;
            for (int i = 0; i < a; i++)
            {
                if (i == mxI) continue;

                int nj = 0;
                for (int j = 0; j < b; j++)
                {
                    if (j == mxJ) continue;

                    answer[ni, nj] = matrix[i, j];
                    nj++;
                }
                ni++;
            }  
            // end

            return answer;
        }
        public void Task3(int[,] matrix)
        {

            // code here
            int a = matrix.GetLength(0);
            int b = matrix.GetLength(1);
            for (int i = 0; i < a; i++)
            {
                int mxI = 0;
                for (int j = 1; j < b; j++)
                {
                    if (matrix[i, j] > matrix[i, mxI])
                    {
                        mxI = j;
                    }
                }
                int maxVal = matrix[i, mxI];
                for (int j = mxI; j < b - 1; j++)
                {
                    matrix[i, j] = matrix[i, j + 1];
                }
                matrix[i, b - 1] = maxVal;
            }
            // end

        }
        public int[,] Task4(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            int a = matrix.GetLength(0);
            int b = matrix.GetLength(1);
            answer = new int[a, b + 1];
            for (int i = 0; i < a; i++)
            {
                int mx = matrix[i, 0];
                for (int j = 1; j < b; j++)
                {
                    if (matrix[i, j] > mx)
                    {
                        mx = matrix[i, j];
                    }
                }
                for (int j = 0; j < b - 1; j++)
                {
                    answer[i, j] = matrix[i, j];
                }
                answer[i, b - 1] = mx;
                answer[i, b] = matrix[i, b - 1];
            }
            // end

            return answer;
        }
        public int[] Task5(int[,] matrix)
        {
            int[] answer = null;

            // code here
            int a = matrix.GetLength(0);
            int b = matrix.GetLength(1);

            int cnt = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if ((i + j) % 2 != 0)
                    {
                        cnt++;
                    }
                }
            }

            answer = new int[cnt];
            int k = 0;

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if ((i + j) % 2 != 0)
                    {
                        answer[k] = matrix[i, j];
                        k++;
                    }
                }
            }
            // end

            return answer;
        }
        public void Task6(int[,] matrix, int k)
        {

            // code here
            int a = matrix.GetLength(0);
            int b = matrix.GetLength(1);

            if (a == 0 || b == 0 || a != b || k < 0 || k >= b)
            {
                return;
            }

            int mxI = 0;
            for (int i = 1; i < a; i++)
            {
                if (matrix[i, i] > matrix[mxI, mxI])
                {
                    mxI = i;
                }
            }

            int minus = -1;
            for (int i = 0; i < a; i++)
            {
                if (matrix[i, k] < 0)
                {
                    minus = i;
                    break;
                }
            }

            if (minus != -1 && mxI != minus)
            {
                for (int j = 0; j < b; j++)
                {
                    int tmp = matrix[mxI, j];
                    matrix[mxI, j] = matrix[minus, j];
                    matrix[minus, j] = tmp;
                }
            }
            // end

        }
        public void Task7(int[,] matrix, int[] array)
        {

            // code here

            // end

        }
        public void Task8(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task9(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task10(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task11(int[,] matrix)
        {

            // code here

            // end

        }
        public int[][] Task12(int[][] array)
        {
            int[][] answer = null;

            // code here

            // end

            return answer;
        }
    }
}
