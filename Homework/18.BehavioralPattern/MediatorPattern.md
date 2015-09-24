# Mediator Design Pattern #
## Intent ##
- Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.
- Design an intermediary to decouple many peers.
- Promote the many-to-many relationships between interacting peers to "full object status".
## Structure ##
![](https://sourcemaking.com/files/v2/content/patterns/Mediator__1-2x.png)

##Example##

     public interface ICentralizedServer
    {
        void Register(IClient participant);

        void Send(string from, string to, IFile file);
    }

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


	public interface IClient
    {
        ICentralizedServer Server { get; }

        string IPAddress { get; }

        void Send(string to, IFile file);

        void Receive(string from, IFile file);
    }

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


	public interface IFile
    {
        float Size { get; }

        string Name { get; }
    }

	public class Song : IFile
    {
        private float size;

        private string name;

        public Song(float size, string name)
        {
            this.Size = size;
            this.Name = name;
        }

        public float Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                this.size = value;
            }
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.name = value;
            }
        }
    }


	public class Program
    {
        static void Main(string[] args)
        {
            ICentralizedServer server = new Server();

            IClient gosho = new Client(server, "192.168.0.5");
            IClient pesho = new Client(server, "192.168.0.1");
            IClient john = new Client(server, "192.168.0.3");

            server.Register(gosho);
            server.Register(pesho);
            server.Register(john);

            IFile song = new Song(5.6f, "All of me :)");
            gosho.Send("192.168.0.1",song);
            gosho.Send("192.168.0.3", song);

            IFile song2 = new Song(5.6f, "Ne me zamari");
            pesho.Send("192.168.0.5", song2);


        }
    }