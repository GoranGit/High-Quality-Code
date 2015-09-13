namespace CentralizedPeerToPeerServer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CentralizedServer
    {
        private static CentralizedServer instance;

        private List<string> clients = new List<string>();

        private Random random = new Random();

        private static object syncLock = new object();

        protected CentralizedServer()
        {
            clients.Add("Client1");
            clients.Add("Client2");
            clients.Add("Client3");
            clients.Add("Client4");
            clients.Add("Client5");
        }

        public static CentralizedServer GetCentralizedServer()
        {
            if (instance == null)
            {
                lock (syncLock)
                {
                    if (instance == null)
                    {
                        instance = new CentralizedServer();
                    }
                }
            }

            return instance;
        }

        public string Client
        {
            get
            {
                int r = random.Next(clients.Count);
                return clients[r].ToString();
            }
        }
    }
}

