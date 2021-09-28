using System;
using System.Threading.Tasks;
using Client;
using System.Collections.Generic;

namespace Server
{
    class Server
    {
        static void Main(string[] args)
        {
            Server1 server = new Server1();
            server.StartServer();
            Task.Factory.StartNew(() => server.Connects());
            try
            {
                while (true)
                {
                    server.SendMsg(Console.ReadLine());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                throw;
            }
        }
    }
}