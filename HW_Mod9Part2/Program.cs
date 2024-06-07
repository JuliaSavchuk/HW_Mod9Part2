namespace HW_Mod9Part2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-----Task 1-----\n");
            Task1.Tas1();

            Console.WriteLine("\n\n-----Task 2-----\n");
            Task2.Tas2();

            Console.WriteLine("\n\n-----Task 3-----\n");
            int[] numbers = { 14, 21, 35, 20, 49, 50, 63, 77, 80, 91, -10, -5, 0, 5, -10, 15, -3, 8, 20 };
            int countMultiplesOfSeven = numbers.Count(x => x % 7 == 0);
            Console.WriteLine($"Count of numbers multiples of seven: {countMultiplesOfSeven}");


            Console.WriteLine("\n\n-----Task 4-----\n");
            int countPositiveNumbers = numbers.Count(x => x > 0);
            Console.WriteLine($"Count of positive numbers: {countPositiveNumbers}");

            Console.WriteLine("\n\n-----Task 5-----\n");
            var uniqueNegativeNumbers = numbers.Where(x => x < 0).Distinct();
            Console.WriteLine("Unique negative numbers: " + string.Join(", ", uniqueNegativeNumbers));

            Console.WriteLine("\n\n-----Task 6-----\n");
            string text = "The quick brown fox jumps over the lazy dog";
            string word = "fox";
            Func<string, bool> containsWord = t => t.Contains(word);
            Console.WriteLine($"Text contains '{word}': {containsWord(text)}");

        }
    }
}