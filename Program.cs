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


            //Дан курс рубля за каждый день феврале месяце (случайным образом) рассчитать средний курс рубля, максимальный курс рубля и день с максимальным курсом, минимальный курс рубля и день с минимальным курсом. Заполнить массив случайным образом. Диапазон от 5-65


            Random random = new Random();
            double[] rubleRates = new double[28];
            for (int i = 0; i < rubleRates.Length; i++ )
            {
                rubleRates[i] =50+ random.NextDouble() * 10.0;
            }

            double total = 0;
            foreach(double rate in rubleRates)
            {
                total += rate;
            }

            double averageRate = total / rubleRates.Length;
            double maxRate = rubleRates[0];
            int maxRateDay = 1;
            double minRate = rubleRates[0];
            int minRateDay = 1;

            for (int i = 1; i < rubleRates.Length; i++)
            {
                if (rubleRates[i] > maxRate)
                {
                    maxRate = rubleRates[i];
                    maxRateDay = i + 1;
                }

                if(rubleRates[i] < maxRate)
                {
                    minRate = rubleRates[i];
                    minRateDay = i + 1;
                }
            }

            Console.WriteLine(averageRate);
            Console.WriteLine($"{maxRate}, {maxRateDay}");
            Console.WriteLine($"{minRate}, {minRateDay}");
        }
    }
}
