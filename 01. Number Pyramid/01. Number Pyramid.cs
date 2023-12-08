namespace _01._Number_Pyramid
{
            internal class Program
        {
            static void Main(string[] args)
            {
                int number = int.Parse(Console.ReadLine());
                int num = 1;



                for (int i = 0; i <= number; i++)
                {
                    if (num > number)

                    { break; }

                    for (int j = 0; j <= i; j++)
                    {
                        if (num > number)

                        { break; }
                        Console.Write(num + " ");
                        num++;
                    }

                    Console.WriteLine();

                }

            }
        }
    }