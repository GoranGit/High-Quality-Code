namespace Mediator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Client : IClient
    {
        private ICentralizedServer server;

        private Dictionary<string, IList<IFile>> receivedFiles;

        private string ipAddress;

        public Client(ICentralizedServer server, string ip)
        {
            this.Server = server;
            this.IPAddress = ip;
            this.receivedFiles = new Dictionary<string, IList<IFile>>();
        }

        public ICentralizedServer Server
        {
            get
            {
                return this.server;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.server = value;
            }
        }

        public string IPAddress
        {
            get
            {
                return this.ipAddress;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.ipAddress = value;
            }
        }

        public void Send(string to, IFile file)
        {
            this.server.Send(this.IPAddress, to, file);

        }

        public void Receive(string from, IFile file)
        {
           
            if (!this.receivedFiles.Keys.Contains(from))
            {
                this.receivedFiles.Add(from, new List<IFile>());
            }

            this.receivedFiles[from].Add(file);
        }
    }
}
