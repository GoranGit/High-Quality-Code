namespace Task_2.Method_PrintStatistics_in_CSharp
{
    using System;
    using System.Text;

    public class Statistics
    {
        public void PrintStatistics(double[] arr, int count)
        {
            string result = string.Format(
                " Min:{0} \n Max:{1} \n Average:{2}",
                   this.GetMin(arr, count),
                   this.GetMax(arr, count),
                   this.GetAverage(arr, count));

            Console.WriteLine(result);
            Console.ReadKey();
        }

        private double GetMax(double[] arr, int count)
        {
            var max = double.MinValue;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        private double GetMin(double[] arr, int count)
        {
            var min = double.MaxValue;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        private double GetAverage(double[] arr, int count)
        {
            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }

            var average = sum / count;
            return average;
        }
    }
}
