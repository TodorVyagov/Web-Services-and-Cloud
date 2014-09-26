namespace DataServiceConsoleClient
{
    using System;

    using DataServiceConsoleClient.ServiceReferenceDateExample;
    using System.Globalization;
    
    internal class Program
    {
        private static void Main()
        {
            DataServiceClient client = new DataServiceClient();
            Console.WriteLine("Днес е " + client.GetDayOfWeek(DateTime.Now, new CultureInfo("bg-BG")));
            // if you cannot read the message above uncomment the line below
            //Console.WriteLine("Today it is " + client.GetDayOfWeek(DateTime.Now, new CultureInfo("en-US")));
        }
    }
}
