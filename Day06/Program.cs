namespace Day06
{

    //Day 6 Problem 1:

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create book using default constructor
            Book book = new Book();
            Console.WriteLine("Default Book: " + book.Name);

            // Create book using parameterized constructor
            Console.Write("Enter book name: ");
            string bookName = Console.ReadLine();

            Console.Write("Enter author name: ");
            string authorName = Console.ReadLine();

            Console.Write("Enter edition: ");
            int edition = int.Parse(Console.ReadLine());

            Console.Write("Enter category: ");
            string category = Console.ReadLine();

            Book paramBook = new Book(bookName, authorName, edition, category);
            Console.WriteLine("Parameterized Book: " + paramBook.Name);

            // Create book using copy constructor
            Book copiedBook = new Book(paramBook);
            Console.WriteLine("Copied Book: " + copiedBook.Name);


            //Tested for visitor
            // Create visitor using default constructor
            Visitor visitor = new Visitor();
            Console.WriteLine("Default Visitor: " + visitor.Name);

            // Create visitor using parameterized constructor
            Console.Write("Enter visitor name: ");
            string visitorName = Console.ReadLine();

            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Visitor paramVisitor = new Visitor(visitorName, phoneNumber, email);
            Console.WriteLine("Parameterized Visitor: " + paramVisitor.Name);

            // Create visitor using copy constructor
            Visitor copiedVisitor = new Visitor(paramVisitor);
            Console.WriteLine("Copied Visitor: " + copiedVisitor.Name);

        }
    }
    class Book
    {
        //Automatic Property 
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Edition { get; set; }
        public string Category { get; set; }

        // Default Constructor
        public Book()
        {
            Name = "Default Title";
        }

        // Parameterized Constructor
        public Book(string name, string authorName, int edition, string category)
        {
            Name = name;
            AuthorName = authorName;
            Edition = edition;
            Category = category;
        }

        // Copy Constructor
        public Book(Book b)
        {
            Name = b.Name;
            AuthorName = b.AuthorName;
            Edition = b.Edition;
            Category = b.Category;
        }
    }

    class Visitor
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // Default Constructor
        public Visitor()
        {
            Name = "Default Title";
        }

        // Parameterized Constructor
        public Visitor(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        // Copy Constructor
        public Visitor(Visitor v)
        {
            Name = v.Name;
            PhoneNumber = v.PhoneNumber;
            Email = v.Email;
        }
    }
}