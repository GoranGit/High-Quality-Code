namespace Mediator
{
    using System;

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
}
