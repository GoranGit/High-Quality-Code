namespace Task_2.Method_PrintStatistics_in_CSharp
{
    public static class StatisticsApplication
    {
        public static void Main()
        {
            double[] arr = { 1.2, 3.2, 43, 5, 6 };
            Statistics statistic = new Statistics();
            statistic.PrintStatistics(arr, 5);
        }
    }
}
