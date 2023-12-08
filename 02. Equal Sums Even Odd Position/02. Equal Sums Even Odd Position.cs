namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());

            
            for (int j = numberA; j <= numberB; j++)
            {
                int sumOfEvenDigit = 0;
                int sumOfOddDigit = 0;

                int n = j;

                for (int i = 6; i > 0; i--)
                {
                    
                    
                    int digit = n % 10;

                    if (i % 2 == 0)
                    {
                        

                            sumOfEvenDigit += digit;
                    }
                    else 
                    {
                            sumOfOddDigit += digit;
                    
                    }
                    n = n/ 10;
    
                }

                if (sumOfEvenDigit == sumOfOddDigit)
                {
                    Console.Write(j + " ");
                }

            }
        }
    }
}