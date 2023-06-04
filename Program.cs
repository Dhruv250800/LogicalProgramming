public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter number");
        int n = Convert.ToInt16(Console.ReadLine());

        FibonacciGenerator fibonacci = new FibonacciGenerator();
        for (int i = 0; i < n; i++)
        {
            int term = fibonacci.Next();
            Console.Write(term + " ");


        }

        int number = 28;

        bool isPerfect = PerfectNumberChecker.IsPerfectNumber(number);

        if (isPerfect)
            Console.WriteLine(number + " is a perfect number.");
        else
            Console.WriteLine(number + " is not a perfect number.");




        int number1 = 17;

        bool isPrime = PrimeNumberChecker.IsPrimeNumber(number1);

        if (isPrime)
            Console.WriteLine(number1 + " is a prime number.");
        else
            Console.WriteLine(number1 + " is not a prime number.");



        int number2 = 12345;

        int reversedNumber = NumberReverser.ReverseNumber(number2);

        Console.WriteLine("Original Number: " + number2);
        Console.WriteLine("Reversed Number: " + reversedNumber);



        int[] couponNumbers = { 1, 2, 3, 4, 5 };

        int totalRandomNumbersNeeded = CouponNumberGenerator.GenerateDistinctCouponNumbers(couponNumbers);

        Console.WriteLine("Total random numbers needed: " + totalRandomNumbersNeeded);






        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        // Simulating some time-consuming operation
        for (int i = 0; i < 1000000000; i++) { }

        stopwatch.Stop();

        stopwatch.DisplayElapsedTime();
    }
}



