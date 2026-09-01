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

            //Question 9:
            int pagesss = 464;
            string pagesString = pagesss.ToString();
            Console.WriteLine(pagesString.GetType());

            // -----------------------

            //Question 10:
            int copies = 100;
            object boxedCopies = copies; // => boxing
            int unBoxedCopies = (int)boxedCopies; // => unboxing

            Console.WriteLine($"boxedCopies: {boxedCopies}, unboxedCopies: {unBoxedCopies}");

            // -----------------------

            //Question 11:
            int? year = null;
            Console.WriteLine(year.HasValue); // => false
            year = 2023;
            Console.WriteLine(year.Value); // => 2023

            // -----------------------

            //Question 12:

            string? reviewer = null;
            Console.WriteLine(reviewer == null); // => true

            // -----------------------

            //Question 13:
            Book? book = null;
            Console.WriteLine(book?.title); // to prevent null reference exception + also it will print nothing 

            // -----------------------

            //Question 14:
            Console.WriteLine(book?.title);
            string? title = book?.title ?? "Untitled";
            Console.WriteLine(title ?? "Untitled");
            title ??= "Untitled"; // now we assigned a title when it is not null
            Console.WriteLine(book?.title); // now it will print Untitled

            // -----------------------
        }
    }
}
