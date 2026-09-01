namespace csharp_basics_ass1
{
    internal class Program
    {
        internal class Book
        {
            public string title;
            public int pages;
        }
        static void Main(string[] args)
        {
            //Question 1:
            Book b1 = new Book()
            {
                title = "Atomic Habits",
                pages = 430
            };
            object b2 = b1;
            Console.WriteLine(b2);

            // -----------------------

            //Question 2:
            Console.WriteLine(b2.ToString());
            Console.WriteLine(b2.Equals(b1));
            Console.WriteLine(b2.GetHashCode());
            Console.WriteLine(b2.GetType());

            // -----------------------

            //Question 3:
            // this is a compilation error

            int pages = 464; // => we fixed by removing the double cotation marks

            // -----------------------

            //Question 4:
            try
            {
                int x = 10;
                int y = 0;
                Console.WriteLine(x / y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            finally
            {
                Console.WriteLine("Done");
            }

            // -----------------------

            //Question 5:
            int pagess = 300;
            double implicitPages = pages;

            // -----------------------

            //Question 6:
            double price = 49.99;
            int explicitPrice = (int)price;


            // -----------------------

            //Question 7:
            string pagesText = "464";
            int pagesInt = int.Parse(pagesText);

            // -----------------------

            //Question 8:
            string yearText = "2023";
            int yearInt = int.Parse(yearText);

            string badText = "abc";
            if (int.TryParse(badText, out int badInt))
            {
                Console.WriteLine(badInt);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            // -----------------------
        }
    }
}
