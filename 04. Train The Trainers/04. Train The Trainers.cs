namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();
            double finalAssessment = 0.0;
            int presentationsCount = 0;

            while (presentationName != "Finish")
            {
                double presentationAssessment = 0.0;

                for (int i = 0; i < juryCount; i++)
                {
                    presentationAssessment += double.Parse(Console.ReadLine());
                }

                presentationAssessment /= juryCount;
                Console.WriteLine($"{presentationName} - {presentationAssessment:F2}.");

                finalAssessment += presentationAssessment;
                presentationsCount++;

                presentationName = Console.ReadLine();
            }

            finalAssessment /= presentationsCount;
            Console.WriteLine($"Student's final assessment is {finalAssessment:F2}.");
        }
    }
}