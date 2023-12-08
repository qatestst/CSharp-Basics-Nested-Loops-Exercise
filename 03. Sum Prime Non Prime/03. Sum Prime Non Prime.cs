namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumPrimes = 0;
            int sumNonPrimes = 0;
            string command;

            while ((command = Console.ReadLine()) != "stop")
            {
                int number = int.Parse(command);
                bool isPrime = number > 1;

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i <= number / 2; i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        sumPrimes += number;
                    }
                    else
                    {
                        sumNonPrimes += number;
                    }
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrimes}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimes}");
        }
    }
}

// Second variant

//namespace _03._Sum_Prime_Non_Prime
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            int sumPrimes = 0;
//int sumNonPrimes = 0;
//string command;

//while ((command = Console.ReadLine()) != "stop")
//{
//    int number = int.Parse(command);
//    bool isPrime = true;

//    if (number < 0)
//    {
//        Console.WriteLine("Number is negative.");
//    }
//    else
//    {
//        if (number <= 1)
//        {
//            isPrime = false;
//        }
//        else
//        {
//            for (int i = 2; i * i <= number; i++) //Условието на цикъла i * i <= number означава, че ще продължим да проверяваме за делители на числото number докато квадратът на i е по-малък или равен на number. Това е ефективен начин да намалим броя на проверките, тъй като ако number има делител по-голям от неговия корен квадратен, то със сигурност ще има и съответен делител, който е по-малък от корена.
//            {                                     // 
//                if (number % i == 0)
//                {
//                    isPrime = false;
//                    break;
//                }
//            }
//        }

//        if (isPrime)
//        {
//            sumPrimes += number;
//        }
//        else
//        {
//            sumNonPrimes += number;
//        }
//    }
//}

//Console.WriteLine($"Sum of all prime numbers is: {sumPrimes}");
//Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimes}");
//        }
//    }
//}

////
///Обяснение за намиране на просто число чрез цикъла "for (int i = 2; i * i <= number; i++)"
//Когато имаме число number и търсим неговите делители, ако намерим делител, който е по-голям от корен квадратен на number, то тогава можем да бъдем сигурни, че ще има и друг делител, който е по-малък от корен квадратен на number.
//Нека да разгледаме числото number като произведение на две числа, a и b, така че number=a×b
//. Ако едно от тези числа, нека да кажем a, е по-голямо от корен квадратен на number, тогава другото число b трябва да е по-малко от корен квадратен на number, за да се получи същият продукт number. Това е така, защото ако и двете числа a и b бяха по-големи от корен квадратен на number, тогава техният продукт би бил по-голям от number, което е противоречие.
//Ето пример: Ако имаме числото 36, корен квадратен на 36 е 6. Ако намерим делител на 36, който е по-голям от 6, например 9, тогава със сигурност ще има и делител, който е по-малък от 6, в този случай 4, защото 36=9×4
//.
//Така, когато проверяваме дали число е просто, ни е достатъчно да проверим делителите до корен квадратен на числото, защото ако има делител, който е по-голям, то със сигурност ще има и съответен делител, който е по-малък от корена. Това ни позволява да намалим броя на проверките и да направим алгоритъма по-ефективен.
