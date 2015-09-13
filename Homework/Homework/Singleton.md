## Singleton pattern
Implementation of a singleton pattern must satisfy the single instance and global access principles. It requires a mechanism to access the singleton class member without creating a class object and a mechanism to persist the value of class members among class objects. The singleton pattern is implemented by creating a class with a method that creates a new instance of the class if one does not exist. If an instance already exists, it simply returns a reference to that object. To make sure that the object cannot be instantiated any other way, the constructor is made private. Note the distinction between a simple static instance of a class and a singleton: although a singleton can be implemented as a static instance, it can also be lazily constructed, requiring no memory or resources until needed.

The singleton pattern must be carefully constructed in multi-threaded applications. If two threads are to execute the creation method at the same time when a singleton does not yet exist, they both must check for an instance of the singleton and then only one should create the new one. If the programming language has concurrent processing capabilities the method should be constructed to execute as a mutually exclusive operation. The classic solution to this problem is to use mutual exclusion on the class that indicates that the object is being instantiated.

![](singleton-img.gif)

 
###### Singleton implementation
~~~c#
public class Singleton
{
   private static Singleton instance;

   private Singleton() {}

   public static Singleton Instance
   {
      get
      {
         if (instance == null)
         {
            instance = new Singleton();
         }
         return instance;
      }
   }
}
~~~
 
###### Multithreading Singleton implementation
~~~c#

public sealed class Singleton
{
   private static volatile Singleton instance;
   private static object syncRoot = new Object();

   private Singleton() {}

   public static Singleton Instance
   {
      get 
      {
         if (instance == null) 
         {
            lock (syncRoot) 
            {
               if (instance == null) 
                  instance = new Singleton();
            }
         }

         return instance;
      }
   }
}
~~~

####Simple Implementation
~~~c#

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


~~~