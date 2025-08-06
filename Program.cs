namespace WeatherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num of days");
            int days = int.Parse(Console.ReadLine() ?? "0");

            int[] temperatures = new int[days];
            string[] condition = { "rainy", "sunny", "cloudy", "snowy" };
            string[] weatherConditions = new string[days];
            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperatures[i] = random.Next(-10, 30);
                weatherConditions[i] = condition[random.Next(condition.Length)];
            }
            double averageTemperature = calculateAverageTemperature(temperatures);
            Console.WriteLine("Weather conditions for the next days are: ");
            printWeatherConditions(weatherConditions);

            Console.WriteLine($"Average temp is: {averageTemperature}");
            Console.WriteLine($"Minimum temp is : {Mintemp(temperatures)}");
        }
        static double calculateAverageTemperature(int[] temperatures)
        {
            int sum = 0;
            foreach (int temp in temperatures)
            {
                sum = sum + temp;
            }
            double average = sum / temperatures.Length;
            return average;
        }
        static void printWeatherConditions(string[] weatherConditions)
        {
            foreach (string condition in weatherConditions)
            {
                Console.WriteLine(condition);
            }
        }
        static int Mintemp(int[] temperatures)
        {
            int min = 0;
            foreach(int temp in temperatures)
            {
                if(min==0|| temp < min)
                {
                    min= temp;
                }
            }
            return min;
        }
    }
}
