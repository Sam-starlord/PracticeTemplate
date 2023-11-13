using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

//namespace PracticeTemplate
//{

//    #region old codes
//    //class HttpServer
//    //{
//    //    public static HttpListener listener;
//    //    public static string url = "http://localhost:8000/";
//    //    public static int pageViews = 0;
//    //    public static int requestCount = 0;
//    //    public static string pageData =
//    //        "<!DOCTYPE>" +
//    //        "<html>" +
//    //        "  <head>" +
//    //        "    <title>HttpListener Example</title>" +
//    //        "  </head>" +
//    //        "  <body>" +
//    //        "    <p>Page Views: {0}</p>" +
//    //        "    <form method=\"post\" action=\"shutdown\">" +
//    //        "      <input type=\"submit\" value=\"Shutdown\" {1}>" +
//    //        "    </form>" +
//    //        "  </body>" +
//    //        "</html>";


//    //    public static async Task HandleIncomingConnections()
//    //    {
//    //        bool runServer = true;

//    //        // While a user hasn't visited the `shutdown` url, keep on handling requests
//    //        while (runServer)
//    //        {
//    //            // Will wait here until we hear from a connection
//    //            HttpListenerContext ctx = await listener.GetContextAsync();

//    //            // Peel out the requests and response objects
//    //            HttpListenerRequest req = ctx.Request;
//    //            HttpListenerResponse resp = ctx.Response;

//    //            // Print out some info about the request
//    //            Console.WriteLine("Request #: {0}", ++requestCount);
//    //            Console.WriteLine(req.Url.ToString());
//    //            Console.WriteLine(req.Httpdocumentethod);
//    //            Console.WriteLine(req.UserHostName);
//    //            Console.WriteLine(req.UserAgent);
//    //            Console.WriteLine();

//    //            // If `shutdown` url requested w/ POST, then shutdown the server after serving the page
//    //            if ((req.Httpdocumentethod == "POST") && (req.Url.AbsolutePath == "/shutdown"))
//    //            {
//    //                Console.WriteLine("Shutdown requested");
//    //                runServer = false;
//    //            }

//    //            // documentake sure we don't increment the page views counter if `favicon.ico` is requested
//    //            if (req.Url.AbsolutePath != "/favicon.ico")
//    //                pageViews += 1;

//    //            // Write the response info
//    //            string disableSubmit = !runServer ? "disabled" : "";
//    //            byte[] data = Encoding.UTF8.GetBytes(String.Format(pageData, pageViews, disableSubmit));
//    //            resp.ContentType = "text/html";
//    //            resp.ContentEncoding = Encoding.UTF8;
//    //            resp.ContentLength64 = data.LongLength;

//    //            // Write out to the response stream (asynchronously), then close it
//    //            await resp.OutputStream.WriteAsync(data, 0, data.Length);
//    //            resp.Close();
//    //        }
//    //    }


//    //    public static void documentain(string[] args)
//    //    {
//    //        // Create a Http server and start listening for incoming connections
//    //        listener = new HttpListener();
//    //        listener.Prefixes.Add(url);
//    //        listener.Start();
//    //        Console.WriteLine("Listening for connections on {0}", url);

//    //        // Handle requests
//    //        Task listenTask = HandleIncomingConnections();
//    //        listenTask.GetAwaiter().GetResult();

//    //        // Close the listener
//    //        listener.Close();
//    //    }
//    //}

//    //class Program
//    //{
//    //    static async Task documentain(string[] args)
//    //    {
//    //        await calldocumentethod();
//    //        Console.ReadKey();
//    //    }

//    //    public static async Task calldocumentethod()
//    //    {
//    //        documentethod2();
//    //        var count = await documentethod1();
//    //        documentethod3(count);
//    //    }

//    //    public static async Task<int> documentethod1()
//    //    {
//    //        int count = 0;
//    //        await Task.Run(() =>
//    //        {
//    //            for (int i = 0; i < 100; i++)
//    //            {
//    //                Console.WriteLine(" documentethod 1");
//    //                count += 1;
//    //            }
//    //        });
//    //        return count;
//    //    }

//    //    public static void documentethod2()
//    //    {
//    //        for (int i = 0; i < 25; i++)
//    //        {
//    //            Console.WriteLine(" documentethod 2");
//    //        }
//    //    }

//    //    public static void documentethod3(int count)
//    //    {
//    //        Console.WriteLine("Total count is " + count);
//    //    }
//    //}

//    //public class LinkedList
//    //{
//    //    Node head; // head of list

//    //    /* Linked list Node. This inner
//    //    class is made static so that
//    //    main() can access it */
//    //    public class Node
//    //    {
//    //        public int data;
//    //        public Node next;
//    //        public Node(int d)
//    //        {
//    //            data = d;
//    //            next = null;

//    //        } // Constructor
//    //    }

//    //    /* This function prints contents of
//    //    linked list starting from head */
//    //    public void printList()
//    //    {
//    //        Node n = head;
//    //        while (n != null)
//    //        {
//    //            Console.Write(n.data + " ");
//    //            n = n.next;
//    //        }
//    //    }

//    //    /* method to create a simple linked list with 3 nodes*/
//    //    public static void documentain(String[] args)
//    //    {
//    //        /* Start with the empty list. */
//    //        LinkedList llist = new LinkedList();

//    //        llist.head = new Node(1);
//    //        Node second = new Node(2);
//    //        Node third = new Node(3);

//    //        llist.head.next = second; // Link first node with the second node
//    //        second.next = third; // Link second node with the third node

//    //        llist.printList();
//    //    }
//    //}


//    #region anagram

//    //class Solution
//    //{
//    //    public static int[] rotLeft(int[] a, int d)
//    //    {
//    //        for (int intI = 0; intI < d; intI++)
//    //        {
//    //            int temp = a[0];

//    //            for (int intK = 0; intK < a.Length - 1; intK++)
//    //            {
//    //                a[a.Length - (a.Length - intK)] = a[a.Length - (a.Length - (intK + 1))];
//    //            }

//    //            a[a.Length - 1] = temp;
//    //        }

//    //        return a;
//    //    }

//    //    static void documentain(String[] args)

//    //    {
//    //        int i, j, z;
//    //        string[] tokens_n = new string[] { "1", "2", "3", "4", "5" };
//    //        int n = Convert.ToInt32(tokens_n[0]);
//    //        int k = Convert.ToInt32(tokens_n[1]);
//    //        string[] a_temp = Console.ReadLine().Split(' ');
//    //        int[] a = Array.ConvertAll(a_temp, Int32.Parse);

//    //        int[] temparray = new int[2 * n];

//    //        //constraints
//    //        if (n >= 100000 || n < 1)
//    //        {
//    //            System.Environment.Exit(1);
//    //        }

//    //        if (k > n || n < 1)
//    //        {
//    //            System.Environment.Exit(1);
//    //        }

//    //        for (i = 0; i < n; i++)
//    //        {
//    //            if (a[i] > 1000000 || a[i] < 1)
//    //            {
//    //                System.Environment.Exit(1);
//    //            }
//    //        }


//    //        for (j = 0; j < n; j++)
//    //        {
//    //            z = (j - k) % n;

//    //            if (z != 0)
//    //            {
//    //                z = (n + z) % n;
//    //            }

//    //            temparray[z] = a[j];
//    //        }

//    //        //view array
//    //        for (i = 0; i < n; i++)
//    //        {
//    //            Console.Write(temparray[i] + " ");
//    //        }


//    //    }
//    //}

//    #endregion



//    #region Abstract code
//    //abstract class Animal /* : Object*/
//    //{

//    //    protected String name;
//    //    protected double weight;

//    //    public Animal()
//    //    {
//    //        Console.WriteLine("Its Abstarct Animal");
//    //    }

//    //    public void eat()
//    //    {
//    //        Console.WriteLine("Abstract animal eats");
//    //    }

//    //    public void breath()
//    //    {
//    //        Console.WriteLine("Abstarct animal breaths");
//    //    }

//    //    public /*abstract*/ void growth()
//    //    {
//    //        Console.WriteLine("abstract animal grows");
//    //    }
//    //}

//    //abstract class documentammal : Animal
//    //{

//    //    protected int teeth;
//    //    protected String diafragma;
//    //    protected int age;

//    //    public documentammal()
//    //    {
//    //        Console.WriteLine("documentammals are animal");
//    //    }

//    //    public void suckle()
//    //    {
//    //        Console.WriteLine("mammals are babies");
//    //    }
//    //}

//    //abstract class Cat : documentammal
//    //{

//    //    protected String breed; // порода

//    //    public Cat()
//    //    {
//    //        Console.WriteLine("cats are mammals");
//    //    }

//    //    public virtual void about()
//    //    {
//    //        Console.WriteLine("cats name " + name);
//    //        Console.WriteLine("cats age: " + age);
//    //    }
//    //}

//    //class documentunchkin : Cat
//    //{

//    //    private short height;

//    //    public documentunchkin()
//    //    {
//    //        Console.WriteLine("Its munchkin");
//    //    }

//    //    public override void about()
//    //    {
//    //        base.about();
//    //        Console.WriteLine("documentunchkins height " + height + "см");
//    //    }
//    //}

//    //public class Program
//    //{

//    //    public static void documentain(String[] args)
//    //    {
//    //        // Animal a = new Animal();
//    //        // Animal a = new documentammal();
//    //        // Animal a = new Cat(); // Cat is abstract; cannot be instantiated
//    //        Animal a = new documentunchkin();
//    //        a.breath();
//    //        a.eat();
//    //        a.growth();
//    //        // a.about();
//    //        Console.ReadLine();
//    //    }
//    //}
//    #endregion
//    #endregion

//    #region delegate
//    //class Program
//    //{
//    //    //public delegate void documentessagedocumente(string msg);
//    //    //public static void documentain(string[] args)
//    //    //{
//    //    //    Delegate msgNew = new documentessagedocumente(Displaydocumentessage);
//    //    //    msgNew.DynamicInvoke("hello");

//    //    //    Console.ReadLine();

//    //    //}

//    //    //public static void Displaydocumentessage(string msg)
//    //    //{
//    //    //    Console.WriteLine(msg);

//    //    //}


//    //    public delegate void Notify();  // delegate

//    //    public class ProcessBusinessLogic
//    //    {
//    //        public event Notify ProcessCompleted; // event

//    //        public void StartProcess()
//    //        {
//    //            Console.WriteLine("Process Started!");
//    //            // some code here..
//    //            OnProcessCompleted();
//    //        }

//    //        protected virtual void OnProcessCompleted() //protected virtual method
//    //        {
//    //            //if ProcessCompleted is not null then call delegate
//    //            ProcessCompleted?.Invoke();
//    //        }
//    //    }

//    //    public static void documentain()
//    //    {
//    //        ProcessBusinessLogic bl = new ProcessBusinessLogic();
//    //        bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
//    //        bl.StartProcess();

//    //        Console.ReadLine();
//    //    }

//    //    // event handler
//    //    public static void bl_ProcessCompleted()
//    //    {
//    //        Console.WriteLine("Process Completed!");
//    //    }

//    //}

//    #endregion

//    #region inerface and abstarct

//    //public abstract class employee
//    //{
//    //    public employee() { Console.WriteLine("constructor"); }

//    //    private string Name { get; set; }
//    //    private int IdNumber { get; set; }
//    //    public int documentobile { get; set; }

//    //    public void getEmployee(string name, int mob, int id)
//    //    {
//    //        Name = name;
//    //        IdNumber = id;
//    //        documentobile = mob;

//    //        Console.WriteLine(Name + IdNumber.ToString() + documentobile.ToString());
//    //        Console.ReadKey();
//    //    }

//    //    public abstract void newdetails();


//    //}

//    //interface IEmpDetails
//    //{
//    //    void empDetails();
//    //}

//    //interface IBossDetails
//    //{
//    //    void BossDetails();
//    //}

//    //public class Demonew : employee
//    //{
//    //    public override void newdetails()
//    //    {
//    //         Console.WriteLine("hello");
//    //    }
//    //}

//    //public class Ibm : IBossDetails,IEmpDetails
//    //{
//    //    public void BossDetails()
//    //    {
//    //        Console.WriteLine("bossimp");
//    //    }

//    //    public void empDetails()
//    //    {
//    //        Console.WriteLine("empimp");
//    //    }
//    //}


//    //class program
//    //{
//    //    public delegate void addnumber(string mg);

//    //    public static void documentain(string[] args)
//    //    {
//    //        Ibm emp = new Ibm();
//    //        emp.BossDetails();
//    //        emp.empDetails();

//    //        Demonew dm = new Demonew();
//    //        dm.getEmployee("Sam", 1, 23434);
//    //        dm.newdetails();


//    //        Console.ReadKey();
//    //        //emp.getEmployee("Sam", 1, 344354);
//    //    }

//    //    public static void Displaydocumentessage(string msg)
//    //    {
//    //        Console.WriteLine(msg);

//    //    }
//    //}

//    #endregion

//    #region not using factory method
//    //interface ICreditcard
//    //{
//    //    string Creditlimit();
//    //    string Cardname();
//    //    string Bank();
//    //}

//    //class platinum : ICreditcard
//    //{
//    //    public string Bank()
//    //    {
//    //        return "ICICI";
//    //    }

//    //    public string Cardname()
//    //    {
//    //        return "Platinum";
//    //    }

//    //    public string Creditlimit()
//    //    {
//    //        return "1K";
//    //    }

//    //    public static string add()
//    //    {
//    //        return "from a class which implements interface";
//    //    }
//    //}

//    //class program
//    //{
//    //    static void documentain(String[] args)
//    //    {
//    //        string cardname = "Platinum";

//    //        ICreditcard creditcard = null;

//    //        if(cardname=="Platinum")
//    //        {
//    //            creditcard = new platinum();
//    //        }

//    //        Console.WriteLine("Details" + creditcard.Bank() + " " + creditcard.Cardname());
//    //        Console.WriteLine(platinum.add());
//    //        Console.ReadKey();

//    //    }
//    //}

//    #endregion

//    #region InterviewCode 

//    //namespace FactoryDesignPattern
//    //{
//    //    interface CreditCard
//    //    {
//    //        string GetCardType();
//    //        int GetCreditLimit();
//    //        int GetAnnualCharge();
//    //    }

//    //    public class Titanium : CreditCard
//    //    {
//    //        public string GetCardType()
//    //        {
//    //            return "Titanium Edge";
//    //        }
//    //        public int GetCreditLimit()
//    //        {
//    //            return 25000;
//    //        }
//    //        public int GetAnnualCharge()
//    //        {
//    //            return 1500;
//    //        }
//    //    }


//    //    class CreditCardFactory
//    //    {
//    //        public static CreditCard GetCreditCard(string cardType)
//    //        {
//    //            CreditCard cardDetails = null;
//    //            if (cardType == "documentoneyBack")
//    //            {
//    //                cardDetails = new documentoneyBack();
//    //            }
//    //            else if (cardType == "Titanium")
//    //            {
//    //                cardDetails = new Titanium();
//    //            }
//    //            else if (cardType == "Platinum")
//    //            {
//    //                cardDetails = new Platinum();
//    //            }
//    //            return cardDetails;
//    //        }
//    //    }

//    //    class Program
//    //    {
//    //        static void documentain(string[] args)
//    //        {
//    //            CreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

//    //            if (cardDetails != null)
//    //            {
//    //                Console.WriteLine("CardType : " + cardDetails.GetCardType());
//    //                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
//    //                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
//    //            }
//    //            else
//    //            {
//    //                Console.Write("Invalid Card Type");
//    //            }
//    //            Console.ReadLine();
//    //        }
//    //    }

//    //}


//    //sealed class Human
//    //{
//    //    public static void Gender()
//    //    {
//    //        Console.WriteLine();
//    //    }
//    //}


//    ////Interface for Animal having Some Sound
//    //interface IAnimal 
//    //{
//    //    void AnimalSounds();
//    //}

//    //class Dog : IAnimal
//    //{
//    //    public void AnimalSounds()
//    //    {
//    //        Console.WriteLine("A dog Barks");
//    //    }
//    //}

//    //class Cat : IAnimal
//    //{
//    //    public void AnimalSounds()
//    //    {
//    //        Console.WriteLine("A Cat meows");
//    //    }
//    //}


//    //class Program
//    //{
//    //    private static void Main(string[] args)
//    //    {
//    //        if (args is null)
//    //        {
//    //            throw new ArgumentNullException(nameof(args));
//    //        }

//    //        Human.Gender();
//    //        IAnimal objDog = new Dog();
//    //        objDog.AnimalSounds();
//    //        Cat objCat = new Cat();
//    //        objCat.AnimalSounds();

//    //        Console.ReadKey();
//    //    }

//    //    internal static void ShowData()
//    //    {
//    //        Console.WriteLine("Data display in internal method");
//    //    }
//    //}
//    #endregion

//    #region mosiac picture
//    //namespace MosaicCollage
//    //{
//    //    class Program
//    //    {
//    //        static void Main(string[] args)
//    //        {
//    //            // Load the images to be used in the mosaic
//    //            List<Image> images = LoadImages();

//    //            // Create a blank image to use as the canvas for the mosaic
//    //            int width = 800;
//    //            int height = 600;
//    //            Bitmap mosaic = new Bitmap(width, height);
//    //            Graphics g = Graphics.FromImage(mosaic);

//    //            // Determine the size of each image in the mosaic
//    //            int imageWidth = width / images.Count;
//    //            int imageHeight = height / images.Count;

//    //            // Create the mosaic by drawing each image on the canvas
//    //            for (int i = 0; i < images.Count; i++)
//    //            {
//    //                Image image = images[i];
//    //                int x = i * imageWidth;
//    //                int y = i * imageHeight;
//    //                g.DrawImage(image, x, y, imageWidth, imageHeight);
//    //            }

//    //            // Save the mosaic to a file
//    //            mosaic.Save("mosaic.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
//    //        }

//    //        static List<Image> LoadImages()
//    //        {
//    //            // This method would typically read images from a folder or database
//    //            // and return a list of images. For this example, we'll just create
//    //            // a list of random images.
//    //            List<Image> images = new List<Image>();
//    //            string[] imageFiles = Directory.GetFiles(@"C:\Users\sranj\Downloads\iloveimg-converted", "*.jpg", SearchOption.AllDirectories);
//    //            Random rnd = new Random();
//    //            Bitmap image = null;
//    //            foreach (var item in imageFiles)
//    //            {
//    //                images.Add(new Bitmap(item));
//    //            }
//    //            //for (int i = 0; i < 10; i++)
//    //            //{
//    //            //    int width = rnd.Next(100, 200);
//    //            //    int height = rnd.Next(100, 200);

//    //            //    using (Graphics g = Graphics.FromImage(image))
//    //            //    {
//    //            //        g.Clear(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
//    //            //    }
//    //            //    images.Add(image);
//    //            //}
//    //            return images;
//    //        }
//    //    }
//    //}
//    #endregion






//}

#region abstarct factory simple

//using System;

//namespace DoFactory.GangOfFour.Abstract.Structural
//{
//    /// <summary>
//    /// MainApp startup class for Structural
//    /// Abstract Factory Design Pattern.
//    /// </summary>

//    class MainApp
//    {
//        /// <summary>
//        /// Entry point into console application.
//        /// </summary>

//        public static void Main()
//        {
//            // Abstract factory #1

//            AbstractFactory factory1 = new ConcreteFactory1();
//            Client client1 = new Client(factory1);
//            client1.Run();

//            // Abstract factory #2

//            AbstractFactory factory2 = new ConcreteFactory2();
//            Client client2 = new Client(factory2);
//            client2.Run();

//            // Wait for user input

//            Console.ReadKey();
//        }
//    }

//    /// <summary>
//    /// The 'AbstractFactory' abstract class
//    /// </summary>

//    abstract class AbstractFactory
//    {
//        public abstract AbstractProductA CreateProductA();
//        public abstract AbstractProductB CreateProductB();
//    }


//    /// <summary>
//    /// The 'ConcreteFactory1' class
//    /// </summary>

//    class ConcreteFactory1 : AbstractFactory
//    {
//        public override AbstractProductA CreateProductA()
//        {
//            return new ProductA1();
//        }
//        public override AbstractProductB CreateProductB()
//        {
//            return new ProductB1();
//        }
//    }

//    /// <summary>
//    /// The 'ConcreteFactory2' class
//    /// </summary>

//    class ConcreteFactory2 : AbstractFactory
//    {
//        public override AbstractProductA CreateProductA()
//        {
//            return new ProductA2();
//        }
//        public override AbstractProductB CreateProductB()
//        {
//            return new ProductB2();
//        }
//    }

//    /// <summary>
//    /// The 'AbstractProductA' abstract class
//    /// </summary>

//    abstract class AbstractProductA
//    {
//    }

//    /// <summary>
//    /// The 'AbstractProductB' abstract class
//    /// </summary>

//    abstract class AbstractProductB
//    {
//        public abstract void Interact(AbstractProductA a);
//    }


//    /// <summary>
//    /// The 'ProductA1' class
//    /// </summary>

//    class ProductA1 : AbstractProductA
//    {
//    }

//    /// <summary>
//    /// The 'ProductB1' class
//    /// </summary>

//    class ProductB1 : AbstractProductB
//    {
//        public override void Interact(AbstractProductA a)
//        {
//            Console.WriteLine(this.GetType().Name +
//              " interacts with " + a.GetType().Name);
//        }
//    }

//    /// <summary>
//    /// The 'ProductA2' class
//    /// </summary>

//    class ProductA2 : AbstractProductA
//    {
//    }

//    /// <summary>
//    /// The 'ProductB2' class
//    /// </summary>

//    class ProductB2 : AbstractProductB
//    {
//        public override void Interact(AbstractProductA a)
//        {
//            Console.WriteLine(this.GetType().Name +
//              " interacts with " + a.GetType().Name);
//        }
//    }

//    /// <summary>
//    /// The 'Client' class. Interaction environment for the products.
//    /// </summary>

//    class Client
//    {
//        private AbstractProductA _abstractProductA;
//        private AbstractProductB _abstractProductB;

//        // Constructor

//        public Client(AbstractFactory factory)
//        {
//            _abstractProductB = factory.CreateProductB();
//            _abstractProductA = factory.CreateProductA();
//        }

//        public void Run()
//        {
//            _abstractProductB.Interact(_abstractProductA);
//        }
//    }
//}

#endregion

//using System;

//namespace practiceData
//{


//    public class Node
//    {
//        public int Data { get; set; }
//        public Node Next { get; set; }

//        public void displayData()
//        {
//            Console.WriteLine(Data);
//        }
//    }

//    public class linkedList
//    {
//        public Node first { get; set; }

//        public void insert(int data)
//        {
//            Node LList = new Node();
//            LList.Data = data;
//            LList.Next = LList;
//            first = LList;
//        }

//        public void Display()
//        {
//            first.displayData();
//        }

//    }


//    class practice
//    {
//        #region string rotation

//        //private static void Main(string[] args)
//        //{
//        //    string s1 = "waterbottle";
//        //    string s2 = "erbottlewat";


//        //  bool str1=  isrotation(s1, s2);
//        //    Console.WriteLine(str1.ToString());
//        //}

//        //public static bool IsSubstring(string s1, string s2)
//        //{
//        //    return s1.Contains(s2);
//        //}


//        //public static bool isrotation(string s1, string s2)
//        //{
//        //    int len=s1.Length;
//        //    if(len==s2.Length & len>0)
//        //    {
//        //        string s1s1 = s1 + s1;
//        //        return IsSubstring(s1s1, s2);
//        //    }



//        //    return false;
//        //}

//#endregion


//        private static void Main(string[] args)
//        {
//            linkedList l1 = new linkedList();
//            l1.insert(32);
//            l1.Display();

//            Console.ReadLine();
//        }

//    }
//}

#region blind 75: 1

//using System;
//using System.Collections.Generic;

//public class TestTheWork
//{
//    public static void Main()
//    {
//        int[] nums = new int[] { 3,2,1,4 };
//        int target = 6;

//        int[] sol = TwoSum(nums, target);

//        Console.WriteLine("Indices of the two numbers that add up to the target: " + sol[0] + ", " + sol[1]);
//        Console.ReadLine();
//    }

//    public static int[] TwoSum(int[] nums, int target)
//    {
//        Dictionary<int, int> numToIndex = new Dictionary<int, int>();

//        for (int i = 0; i < nums.Length; i++)
//        {
//            int complement = target - nums[i];

//            if (numToIndex.ContainsKey(complement))
//            {
//                return new int[] { numToIndex[complement], i };
//            }

//            numToIndex[nums[i]] = i;
//        }

//        // No solution found
//        throw new ArgumentException("No solution exists.");
//    }
//}

#endregion

using System;
using System.Text;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        // Create the link list.
        string[] words =
            { "the", "fox", "jumps", "over", "the", "dog" };
        LinkedList<string> sentence = new LinkedList<string>(words);
        Display(sentence, "The linked list values:");
        Console.WriteLine("sentence.Contains(\"jumps\") = {0}",
            sentence.Contains("jumps"));

        // Add the word 'today' to the beginning of the linked list.
        sentence.AddFirst("today");
        Display(sentence, "Test 1: Add 'today' to beginning of the list:");

        // Move the first node to be the last node.
        LinkedListNode<string> mark1 = sentence.First;
        sentence.RemoveFirst();
        sentence.AddLast(mark1);
        Display(sentence, "Test 2: Move first node to be last node:");

        // Change the last node to 'yesterday'.
        sentence.RemoveLast();
        sentence.AddLast("yesterday");
        Display(sentence, "Test 3: Change the last node to 'yesterday':");

        // Move the last node to be the first node.
        mark1 = sentence.Last;
        sentence.RemoveLast();
        sentence.AddFirst(mark1);
        Display(sentence, "Test 4: Move last node to be first node:");

        // Indicate the last occurence of 'the'.
        sentence.RemoveFirst();
        LinkedListNode<string> current = sentence.FindLast("the");
        IndicateNode(current, "Test 5: Indicate last occurence of 'the':");

        // Add 'lazy' and 'old' after 'the' (the LinkedListNode named current).
        sentence.AddAfter(current, "old");
        sentence.AddAfter(current, "lazy");
        IndicateNode(current, "Test 6: Add 'lazy' and 'old' after 'the':");

        // Indicate 'fox' node.
        current = sentence.Find("fox");
        IndicateNode(current, "Test 7: Indicate the 'fox' node:");

        // Add 'quick' and 'brown' before 'fox':
        sentence.AddBefore(current, "quick");
        sentence.AddBefore(current, "brown");
        IndicateNode(current, "Test 8: Add 'quick' and 'brown' before 'fox':");

        // Keep a reference to the current node, 'fox',
        // and to the previous node in the list. Indicate the 'dog' node.
        mark1 = current;
        LinkedListNode<string> mark2 = current.Previous;
        current = sentence.Find("dog");
        IndicateNode(current, "Test 9: Indicate the 'dog' node:");

        // The AddBefore method throws an InvalidOperationException
        // if you try to add a node that already belongs to a list.
        Console.WriteLine("Test 10: Throw exception by adding node (fox) already in the list:");
        try
        {
            sentence.AddBefore(current, mark1);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Exception message: {0}", ex.Message);
        }
        Console.WriteLine();

        // Remove the node referred to by mark1, and then add it
        // before the node referred to by current.
        // Indicate the node referred to by current.
        sentence.Remove(mark1);
        sentence.AddBefore(current, mark1);
        IndicateNode(current, "Test 11: Move a referenced node (fox) before the current node (dog):");

        // Remove the node referred to by current.
        sentence.Remove(current);
        IndicateNode(current, "Test 12: Remove current node (dog) and attempt to indicate it:");

        // Add the node after the node referred to by mark2.
        sentence.AddAfter(mark2, current);
        IndicateNode(current, "Test 13: Add node removed in test 11 after a referenced node (brown):");

        // The Remove method finds and removes the
        // first node that that has the specified value.
        sentence.Remove("old");
        Display(sentence, "Test 14: Remove node that has the value 'old':");

        // When the linked list is cast to ICollection(Of String),
        // the Add method adds a node to the end of the list.
        sentence.RemoveLast();
        ICollection<string> icoll = sentence;
        icoll.Add("rhinoceros");
        Display(sentence, "Test 15: Remove last node, cast to ICollection, and add 'rhinoceros':");

        Console.WriteLine("Test 16: Copy the list to an array:");
        // Create an array with the same number of
        // elements as the linked list.
        string[] sArray = new string[sentence.Count];
        sentence.CopyTo(sArray, 0);

        foreach (string s in sArray)
        {
            Console.WriteLine(s);
        }

        // Release all the nodes.
        sentence.Clear();

        Console.WriteLine();
        Console.WriteLine("Test 17: Clear linked list. Contains 'jumps' = {0}",
            sentence.Contains("jumps"));

        Console.ReadLine();
    }

    private static void Display(LinkedList<string> words, string test)
    {
        Console.WriteLine(test);
        foreach (string word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    private static void IndicateNode(LinkedListNode<string> node, string test)
    {
        Console.WriteLine(test);
        if (node.List == null)
        {
            Console.WriteLine("Node '{0}' is not in the list.\n",
                node.Value);
            return;
        }

        StringBuilder result = new StringBuilder("(" + node.Value + ")");
        LinkedListNode<string> nodeP = node.Previous;

        while (nodeP != null)
        {
            result.Insert(0, nodeP.Value + " ");
            nodeP = nodeP.Previous;
        }

        node = node.Next;
        while (node != null)
        {
            result.Append(" " + node.Value);
            node = node.Next;
        }

        Console.WriteLine(result);
        Console.WriteLine();
    }
}