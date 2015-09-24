namespace Mediator
{
    using System;
    using System.Collections.Generic;

    public class Server : ICentralizedServer
    {
        private Dictionary<string, IClient> clients;

        public Server()
        {
            this.clients = new Dictionary<string, IClient>();
        }

        public void Register(IClient participant)
        {
            if (participant != null)
            {
                this.clients.Add(participant.IPAddress, participant);
            }
            else
            {
                throw new ArgumentNullException("Client must be  not null object!");
            }
        }

        public void Send(string from, string to, IFile file)
        {
            Console.WriteLine("File with name '"+ file.Name +"' was send to " + to);

            IClient receiver = this.clients[to];
            receiver.Receive(from, file);

            Console.WriteLine("Thanks " + from);
        }
    }
}
