namespace Vistor
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitorTracker tracker1 = VisitorTracker.GetInstance();
            VisitorTracker tracker2 = VisitorTracker.GetInstance();
            VisitorTracker tracker3 = VisitorTracker.GetInstance();

            int visitorCount = tracker1.GetVisitorCount();
            Console.WriteLine($"Number of visitors: {visitorCount}");

            if (tracker1 == tracker2 && tracker2 == tracker3)
            {
                Console.WriteLine("Singleton Works");
            }
            else
            {
                Console.WriteLine("Oops! Singleton doesn't work");
            }

        }
    }
}