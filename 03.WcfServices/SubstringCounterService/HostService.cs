namespace SubstringCounterService
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;

    internal class HostService
    {
        private static void Main()
        {
            Uri serviceAddress = new Uri("http://localhost:1234/calc");
            ServiceHost selfHost = new ServiceHost(typeof(StringCounterService), serviceAddress);

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            selfHost.Description.Behaviors.Add(smb);

            using (selfHost)
            {
                selfHost.Open();
                System.Console.WriteLine("The service is started at endpoint " + serviceAddress);
                string text = "aaaaaa";
                string phrase = "a";
                StringCounterServiceClient
                Console.WriteLine("{0} is contained in {1} {2} times", );
                System.Console.WriteLine("Press [Enter] to exit.");

                System.Console.ReadLine();
            }
        }
    }
}
