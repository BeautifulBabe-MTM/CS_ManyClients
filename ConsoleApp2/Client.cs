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

                    Console.WriteLine(client.GetMsg().ToString());

                }


                //client.Disconnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}