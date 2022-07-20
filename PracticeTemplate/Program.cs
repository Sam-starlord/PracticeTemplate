using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeTemplate
{

    #region old codes
    //class HttpServer
    //{
    //    public static HttpListener listener;
    //    public static string url = "http://localhost:8000/";
    //    public static int pageViews = 0;
    //    public static int requestCount = 0;
    //    public static string pageData =
    //        "<!DOCTYPE>" +
    //        "<html>" +
    //        "  <head>" +
    //        "    <title>HttpListener Example</title>" +
    //        "  </head>" +
    //        "  <body>" +
    //        "    <p>Page Views: {0}</p>" +
    //        "    <form method=\"post\" action=\"shutdown\">" +
    //        "      <input type=\"submit\" value=\"Shutdown\" {1}>" +
    //        "    </form>" +
    //        "  </body>" +
    //        "</html>";


    //    public static async Task HandleIncomingConnections()
    //    {
    //        bool runServer = true;

    //        // While a user hasn't visited the `shutdown` url, keep on handling requests
    //        while (runServer)
    //        {
    //            // Will wait here until we hear from a connection
    //            HttpListenerContext ctx = await listener.GetContextAsync();

    //            // Peel out the requests and response objects
    //            HttpListenerRequest req = ctx.Request;
    //            HttpListenerResponse resp = ctx.Response;

    //            // Print out some info about the request
    //            Console.WriteLine("Request #: {0}", ++requestCount);
    //            Console.WriteLine(req.Url.ToString());
    //            Console.WriteLine(req.Httpdocumentethod);
    //            Console.WriteLine(req.UserHostName);
    //            Console.WriteLine(req.UserAgent);
    //            Console.WriteLine();

    //            // If `shutdown` url requested w/ POST, then shutdown the server after serving the page
    //            if ((req.Httpdocumentethod == "POST") && (req.Url.AbsolutePath == "/shutdown"))
    //            {
    //                Console.WriteLine("Shutdown requested");
    //                runServer = false;
    //            }

    //            // documentake sure we don't increment the page views counter if `favicon.ico` is requested
    //            if (req.Url.AbsolutePath != "/favicon.ico")
    //                pageViews += 1;

    //            // Write the response info
    //            string disableSubmit = !runServer ? "disabled" : "";
    //            byte[] data = Encoding.UTF8.GetBytes(String.Format(pageData, pageViews, disableSubmit));
    //            resp.ContentType = "text/html";
    //            resp.ContentEncoding = Encoding.UTF8;
    //            resp.ContentLength64 = data.LongLength;

    //            // Write out to the response stream (asynchronously), then close it
    //            await resp.OutputStream.WriteAsync(data, 0, data.Length);
    //            resp.Close();
    //        }
    //    }


    //    public static void documentain(string[] args)
    //    {
    //        // Create a Http server and start listening for incoming connections
    //        listener = new HttpListener();
    //        listener.Prefixes.Add(url);
    //        listener.Start();
    //        Console.WriteLine("Listening for connections on {0}", url);

    //        // Handle requests
    //        Task listenTask = HandleIncomingConnections();
    //        listenTask.GetAwaiter().GetResult();

    //        // Close the listener
    //        listener.Close();
    //    }
    //}

    //class Program
    //{
    //    static async Task documentain(string[] args)
    //    {
    //        await calldocumentethod();
    //        Console.ReadKey();
    //    }

    //    public static async Task calldocumentethod()
    //    {
    //        documentethod2();
    //        var count = await documentethod1();
    //        documentethod3(count);
    //    }

    //    public static async Task<int> documentethod1()
    //    {
    //        int count = 0;
    //        await Task.Run(() =>
    //        {
    //            for (int i = 0; i < 100; i++)
    //            {
    //                Console.WriteLine(" documentethod 1");
    //                count += 1;
    //            }
    //        });
    //        return count;
    //    }

    //    public static void documentethod2()
    //    {
    //        for (int i = 0; i < 25; i++)
    //        {
    //            Console.WriteLine(" documentethod 2");
    //        }
    //    }

    //    public static void documentethod3(int count)
    //    {
    //        Console.WriteLine("Total count is " + count);
    //    }
    //}

    //public class LinkedList
    //{
    //    Node head; // head of list

    //    /* Linked list Node. This inner
    //    class is made static so that
    //    main() can access it */
    //    public class Node
    //    {
    //        public int data;
    //        public Node next;
    //        public Node(int d)
    //        {
    //            data = d;
    //            next = null;

    //        } // Constructor
    //    }

    //    /* This function prints contents of
    //    linked list starting from head */
    //    public void printList()
    //    {
    //        Node n = head;
    //        while (n != null)
    //        {
    //            Console.Write(n.data + " ");
    //            n = n.next;
    //        }
    //    }

    //    /* method to create a simple linked list with 3 nodes*/
    //    public static void documentain(String[] args)
    //    {
    //        /* Start with the empty list. */
    //        LinkedList llist = new LinkedList();

    //        llist.head = new Node(1);
    //        Node second = new Node(2);
    //        Node third = new Node(3);

    //        llist.head.next = second; // Link first node with the second node
    //        second.next = third; // Link second node with the third node

    //        llist.printList();
    //    }
    //}


    #region anagram

    //class Solution
    //{
    //    public static int[] rotLeft(int[] a, int d)
    //    {
    //        for (int intI = 0; intI < d; intI++)
    //        {
    //            int temp = a[0];

    //            for (int intK = 0; intK < a.Length - 1; intK++)
    //            {
    //                a[a.Length - (a.Length - intK)] = a[a.Length - (a.Length - (intK + 1))];
    //            }

    //            a[a.Length - 1] = temp;
    //        }

    //        return a;
    //    }

    //    static void documentain(String[] args)

    //    {
    //        int i, j, z;
    //        string[] tokens_n = new string[] { "1", "2", "3", "4", "5" };
    //        int n = Convert.ToInt32(tokens_n[0]);
    //        int k = Convert.ToInt32(tokens_n[1]);
    //        string[] a_temp = Console.ReadLine().Split(' ');
    //        int[] a = Array.ConvertAll(a_temp, Int32.Parse);

    //        int[] temparray = new int[2 * n];

    //        //constraints
    //        if (n >= 100000 || n < 1)
    //        {
    //            System.Environment.Exit(1);
    //        }

    //        if (k > n || n < 1)
    //        {
    //            System.Environment.Exit(1);
    //        }

    //        for (i = 0; i < n; i++)
    //        {
    //            if (a[i] > 1000000 || a[i] < 1)
    //            {
    //                System.Environment.Exit(1);
    //            }
    //        }


    //        for (j = 0; j < n; j++)
    //        {
    //            z = (j - k) % n;

    //            if (z != 0)
    //            {
    //                z = (n + z) % n;
    //            }

    //            temparray[z] = a[j];
    //        }

    //        //view array
    //        for (i = 0; i < n; i++)
    //        {
    //            Console.Write(temparray[i] + " ");
    //        }


    //    }
    //}

    #endregion



    #region Abstract code
    //abstract class Animal /* : Object*/
    //{

    //    protected String name;
    //    protected double weight;

    //    public Animal()
    //    {
    //        Console.WriteLine("Its Abstarct Animal");
    //    }

    //    public void eat()
    //    {
    //        Console.WriteLine("Abstract animal eats");
    //    }

    //    public void breath()
    //    {
    //        Console.WriteLine("Abstarct animal breaths");
    //    }

    //    public /*abstract*/ void growth()
    //    {
    //        Console.WriteLine("abstract animal grows");
    //    }
    //}

    //abstract class documentammal : Animal
    //{

    //    protected int teeth;
    //    protected String diafragma;
    //    protected int age;

    //    public documentammal()
    //    {
    //        Console.WriteLine("documentammals are animal");
    //    }

    //    public void suckle()
    //    {
    //        Console.WriteLine("mammals are babies");
    //    }
    //}

    //abstract class Cat : documentammal
    //{

    //    protected String breed; // порода

    //    public Cat()
    //    {
    //        Console.WriteLine("cats are mammals");
    //    }

    //    public virtual void about()
    //    {
    //        Console.WriteLine("cats name " + name);
    //        Console.WriteLine("cats age: " + age);
    //    }
    //}

    //class documentunchkin : Cat
    //{

    //    private short height;

    //    public documentunchkin()
    //    {
    //        Console.WriteLine("Its munchkin");
    //    }

    //    public override void about()
    //    {
    //        base.about();
    //        Console.WriteLine("documentunchkins height " + height + "см");
    //    }
    //}

    //public class Program
    //{

    //    public static void documentain(String[] args)
    //    {
    //        // Animal a = new Animal();
    //        // Animal a = new documentammal();
    //        // Animal a = new Cat(); // Cat is abstract; cannot be instantiated
    //        Animal a = new documentunchkin();
    //        a.breath();
    //        a.eat();
    //        a.growth();
    //        // a.about();
    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #endregion

    #region delegate
    //class Program
    //{
    //    //public delegate void documentessagedocumente(string msg);
    //    //public static void documentain(string[] args)
    //    //{
    //    //    Delegate msgNew = new documentessagedocumente(Displaydocumentessage);
    //    //    msgNew.DynamicInvoke("hello");

    //    //    Console.ReadLine();

    //    //}

    //    //public static void Displaydocumentessage(string msg)
    //    //{
    //    //    Console.WriteLine(msg);

    //    //}


    //    public delegate void Notify();  // delegate

    //    public class ProcessBusinessLogic
    //    {
    //        public event Notify ProcessCompleted; // event

    //        public void StartProcess()
    //        {
    //            Console.WriteLine("Process Started!");
    //            // some code here..
    //            OnProcessCompleted();
    //        }

    //        protected virtual void OnProcessCompleted() //protected virtual method
    //        {
    //            //if ProcessCompleted is not null then call delegate
    //            ProcessCompleted?.Invoke();
    //        }
    //    }

    //    public static void documentain()
    //    {
    //        ProcessBusinessLogic bl = new ProcessBusinessLogic();
    //        bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
    //        bl.StartProcess();

    //        Console.ReadLine();
    //    }

    //    // event handler
    //    public static void bl_ProcessCompleted()
    //    {
    //        Console.WriteLine("Process Completed!");
    //    }

    //}

    #endregion

    #region inerface and abstarct

    //public abstract class employee
    //{
    //    public employee() { Console.WriteLine("constructor"); }

    //    private string Name { get; set; }
    //    private int IdNumber { get; set; }
    //    public int documentobile { get; set; }

    //    public void getEmployee(string name, int mob, int id)
    //    {
    //        Name = name;
    //        IdNumber = id;
    //        documentobile = mob;

    //        Console.WriteLine(Name + IdNumber.ToString() + documentobile.ToString());
    //        Console.ReadKey();
    //    }

    //    public abstract void newdetails();


    //}

    //interface IEmpDetails
    //{
    //    void empDetails();
    //}

    //interface IBossDetails
    //{
    //    void BossDetails();
    //}

    //public class Demonew : employee
    //{
    //    public override void newdetails()
    //    {
    //         Console.WriteLine("hello");
    //    }
    //}

    //public class Ibm : IBossDetails,IEmpDetails
    //{
    //    public void BossDetails()
    //    {
    //        Console.WriteLine("bossimp");
    //    }

    //    public void empDetails()
    //    {
    //        Console.WriteLine("empimp");
    //    }
    //}


    //class program
    //{
    //    public delegate void addnumber(string mg);

    //    public static void documentain(string[] args)
    //    {
    //        Ibm emp = new Ibm();
    //        emp.BossDetails();
    //        emp.empDetails();

    //        Demonew dm = new Demonew();
    //        dm.getEmployee("Sam", 1, 23434);
    //        dm.newdetails();


    //        Console.ReadKey();
    //        //emp.getEmployee("Sam", 1, 344354);
    //    }

    //    public static void Displaydocumentessage(string msg)
    //    {
    //        Console.WriteLine(msg);

    //    }
    //}

    #endregion

    #region not using factory method
    //interface ICreditcard
    //{
    //    string Creditlimit();
    //    string Cardname();
    //    string Bank();
    //}

    //class platinum : ICreditcard
    //{
    //    public string Bank()
    //    {
    //        return "ICICI";
    //    }

    //    public string Cardname()
    //    {
    //        return "Platinum";
    //    }

    //    public string Creditlimit()
    //    {
    //        return "1K";
    //    }

    //    public static string add()
    //    {
    //        return "from a class which implements interface";
    //    }
    //}

    //class program
    //{
    //    static void documentain(String[] args)
    //    {
    //        string cardname = "Platinum";

    //        ICreditcard creditcard = null;

    //        if(cardname=="Platinum")
    //        {
    //            creditcard = new platinum();
    //        }

    //        Console.WriteLine("Details" + creditcard.Bank() + " " + creditcard.Cardname());
    //        Console.WriteLine(platinum.add());
    //        Console.ReadKey();

    //    }
    //}

    #endregion

    //namespace FactoryDesignPattern
    //{
    //    interface CreditCard
    //    {
    //        string GetCardType();
    //        int GetCreditLimit();
    //        int GetAnnualCharge();
    //    }

    //    public class Titanium : CreditCard
    //    {
    //        public string GetCardType()
    //        {
    //            return "Titanium Edge";
    //        }
    //        public int GetCreditLimit()
    //        {
    //            return 25000;
    //        }
    //        public int GetAnnualCharge()
    //        {
    //            return 1500;
    //        }
    //    }


    //    class CreditCardFactory
    //    {
    //        public static CreditCard GetCreditCard(string cardType)
    //        {
    //            CreditCard cardDetails = null;
    //            if (cardType == "documentoneyBack")
    //            {
    //                cardDetails = new documentoneyBack();
    //            }
    //            else if (cardType == "Titanium")
    //            {
    //                cardDetails = new Titanium();
    //            }
    //            else if (cardType == "Platinum")
    //            {
    //                cardDetails = new Platinum();
    //            }
    //            return cardDetails;
    //        }
    //    }

    //    class Program
    //    {
    //        static void documentain(string[] args)
    //        {
    //            CreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

    //            if (cardDetails != null)
    //            {
    //                Console.WriteLine("CardType : " + cardDetails.GetCardType());
    //                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
    //                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
    //            }
    //            else
    //            {
    //                Console.Write("Invalid Card Type");
    //            }
    //            Console.ReadLine();
    //        }
    //    }

    //}

    sealed class Human
    {
        public static void Gender()
        {
            Console.WriteLine();
        }
    }


    //Interface for Animal having Some Sound
    interface IAnimal 
    {
        void AnimalSounds();
    }

    class Dog : IAnimal
    {
        public void AnimalSounds()
        {
            Console.WriteLine("A dog Barks");
        }
    }

    class Cat : IAnimal
    {
        public void AnimalSounds()
        {
            Console.WriteLine("A Cat meows");
        }
    }


    class Program
    {
        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Human.Gender();
            IAnimal objDog = new Dog();
            objDog.AnimalSounds();
            Cat objCat = new Cat();
            objCat.AnimalSounds();

            Console.ReadKey();
        }
       
        internal static void ShowData()
        {
            Console.WriteLine("Data display in internal method");
        }
    }
}






