using System;

class Program
{
    static void Main()
    {
        // Create an integer array of 10 elements
        int[] numbers = new int[10];
        Random rand = new Random();

        // Fill array with random numbers between 1 and 100
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 101);
        }

        // Print array values
        Console.WriteLine("Array values:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        // Calculate sum using foreach loop
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Calculate mean
        double mean = (double)sum / numbers.Length;

        // Find median
        Array.Sort(numbers);
        double median = (numbers[4] + numbers[5]) / 2.0;

        // Find mode
        int mode = numbers[0];
        int maxCount = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] == numbers[i])
                    count++;
            }

            if (count > maxCount)
            {
                maxCount = count;
                mode = numbers[i];
            }
        }

        // Print results
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Mean: " + mean);
        Console.WriteLine("Median: " + median);
        Console.WriteLine("Mode: " + mode);
    }
}