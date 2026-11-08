using System.Linq;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class Purple
    {
        public int[] Task1(int[,] matrix)
        {
            int[] answer = null;

            // code here
            int a = matrix.GetLength(0); //строки
            int b = matrix.GetLength(1); //столбцы
            answer = new int[b];
            int cnt = 0;
            for (int i = 0; i < b; i++)
            {
                cnt = 0;
                for (int j = 0; j < a; j++)
                {
                    if (matrix[j, i] < 0)
                    {
                        cnt++;
                    }
                }
                answer[i] = cnt;
            }

            // end

            return answer;
        }
        public void Task2(int[,] matrix)
        {

            // code here
            int a = matrix.GetLength(0);
            int b = matrix.GetLength(1);
            for (int i = 0; i < a; i++)
            {
                int minIndex = 0;
                for (int j = 1; j < b; j++)
                {
                    if (matrix[i, j] < matrix[i, minIndex])
                    {
                        minIndex = j;
                    }
                }
                for (int j = minIndex; j > 0; j--)
                {
                    int c = matrix[i, j];
                    matrix[i, j] = matrix[i, j - 1];
                    matrix[i, j - 1] = c;
                }
            }
            // end

        }
        public int[,] Task3(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            int a = matrix.GetLength(0);
            int b = matrix.GetLength(1);
            answer = new int[a, b + 1];
            for (int i = 0; i < a; i++)
            {
                int maxIndex = 0;
                int maxZnach = matrix[i, 0];
                for (int j = 1; j < b; j++)
                {
                    if (matrix[i, j] > matrix[i, maxIndex])
                    {
                        maxIndex = j;
                        maxZnach = matrix[i, j];
                    }
                }
                int cnt = 0;
                for (int j = 0; j < b + 1; j++)
                {
                    if (j == maxIndex + 1)
                    {
                        answer[i, j] = maxZnach;
                    }
                    else
                    {
                        answer[i, j] = matrix[i, cnt];
                        cnt++;
                    }
                }
            }
            // end

            return answer;
        }
        public void Task4(int[,] matrix)
        {

            // code here
            int a = matrix.GetLength(0);
            int b = matrix.GetLength(1);
            for (int i = 0; i < a; i++)
            {
                int maxIndex = 0;
                for (int j = 1; j < b; j++)
                {
                    if (matrix[i, j] > matrix[i, maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                int s = 0;
                int cnt = 0;
                for (int j = maxIndex + 1; j < b; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        s += matrix[i, j];
                        cnt++;
                    }
                }
                if (cnt > 0)
                {
                    int avg = s / cnt;

                    for (int j = 0; j < maxIndex; j++)
                    {
                        if (matrix[i, j] < 0)
                        {
                            matrix[i, j] = avg;
                        }
                    }
                }
            }
            // end

        }
        public void Task5(int[,] matrix, int k)
        {

            // code here

            // end

        }
        public void Task6(int[,] matrix, int[] array)
        {

            // code here

            // end

        }
        public void Task7(int[,] matrix)
        {

            // code here

            // end

        }
        public int[] Task8(int[,] matrix)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task9(int[,] matrix, int k)
        {

            // code here

            // end

        }
        public int[,] Task10(int[,] A, int[,] B)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public int[][] Task11(int[,] matrix)
        {
            int[][] answer = null;

            // code here

            // end

            return answer;
        }
        public int[,] Task12(int[][] array)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
    }
}   
