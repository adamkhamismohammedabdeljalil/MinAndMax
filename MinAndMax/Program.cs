namespace MinAndMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> randomNumbers = new List<int>();
            Random randomNumber = new Random();
            for (var i = 0; i < 1000; i++)
            {
                int randomInt = randomNumber.Next();
                randomNumbers.Add(randomInt);

            }
            foreach (var number in randomNumbers)
            {
                Console.WriteLine(number);

            }

            int minValue = randomNumbers.Min();
            Console.WriteLine("Minimum Value :");
            Console.WriteLine(minValue);
            int maxValue = randomNumbers.Max();
            Console.WriteLine("Maximum Value:");
            Console.WriteLine(maxValue);
        }
    }
}