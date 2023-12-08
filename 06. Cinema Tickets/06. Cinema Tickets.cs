namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalTickets = 0;
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            string command;
            while ((command = Console.ReadLine()) != "Finish")
            {
                string movieName = command;
                int freeSeats = int.Parse(Console.ReadLine());
                int soldTickets = 0;

                string ticketType;
                while ((ticketType = Console.ReadLine()) != "End")
                {
                    switch (ticketType)
                    {
                        case "student":
                            studentTickets++;
                            break;
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                    }
                    soldTickets++;
                    if (soldTickets >= freeSeats)
                    {
                        break;
                    }
                }

                totalTickets += soldTickets;
                double percentageFull = (double)soldTickets / freeSeats * 100;
                Console.WriteLine($"{movieName} - {percentageFull:F2}% full.");
            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)studentTickets / totalTickets * 100:F2}% student tickets.");
            Console.WriteLine($"{(double)standardTickets / totalTickets * 100:F2}% standard tickets.");
            Console.WriteLine($"{(double)kidTickets / totalTickets * 100:F2}% kids tickets.");
        }
    }
}