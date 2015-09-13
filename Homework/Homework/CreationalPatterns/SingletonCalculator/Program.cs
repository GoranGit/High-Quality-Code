namespace CentralizedPeerToPeerServer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            CentralizedServer b1 = CentralizedServer.GetCentralizedServer();
            CentralizedServer b2 = CentralizedServer.GetCentralizedServer();
            CentralizedServer b3 = CentralizedServer.GetCentralizedServer();
            CentralizedServer b4 = CentralizedServer.GetCentralizedServer();

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            CentralizedServer server = CentralizedServer.GetCentralizedServer();

            for (int i = 0; i < 15; i++)
            {
                string client = server.Client;
                Console.WriteLine("Send File to: " + client);
            }
            Console.ReadKey();
        }
    }
}
