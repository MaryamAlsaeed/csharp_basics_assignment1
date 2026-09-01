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
        }
    }
    }
