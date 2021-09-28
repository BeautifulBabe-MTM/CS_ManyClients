using System;

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            Client1 client = new Client1();
            try
            {
                client.Connect();
                while (true)
                {
                    //Console.WriteLine(client.GetMsg().ToString());
                    Console.WriteLine("Enter the browser");
                    string browser = Console.ReadLine();
                    client.SendMsg(browser);
                    string msg = client.GetMsg().ToString();
                    if(msg.ToLower() == "exit")
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}