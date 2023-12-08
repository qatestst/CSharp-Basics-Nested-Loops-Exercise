namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int num = 1111; num <= 9999; num++)
            {
                bool isSpecial = true;
                int currentNum = num;

                for (int i = 0; i < 4; i++)
                {
                    int digit = currentNum % 10;
                    currentNum /= 10;

                    if (digit == 0 || number % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }

                if (isSpecial)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}