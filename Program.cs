using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 3 Zadanie  


            //const int SIZE = 20;
            //double[] weights = new double[SIZE];
            //Random random = new Random();

            //for (int i = 0; i < SIZE; i++)
            //{
            //    weights[i] = random.NextDouble() * 50 + 50;
            //}

            //double sum = 0;
            //for (int i = 0; i < SIZE; i++)
            //{
            //    sum += weights[i];
            //}
            //double average = sum / SIZE;

            //Console.WriteLine("Средний вес: " + average);




            // Нахождение максимального элемента и его индекса одномерного массива 

            int[] array = {8, -1, 4, 16, -5, 3};
            int max = array[0];
            int indexMax = 0;

            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) {
                    max = array[i]; indexMax = i;
                }
            }

            Console.WriteLine($"max = {max}\t indexMax = {indexMax}");
        }
    }
}
