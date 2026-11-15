using System;
// Q01
{
    object book = new Book { Title = "Clean Code", Pages = 464 };
    Console.WriteLine("Q01: " + book); // prints the type name: Book
}

// Q02
{
    Book book = new Book { Title = "Clean Code", Pages = 464 };
    Console.WriteLine("Q02:");
    Console.WriteLine(book.ToString());
    Console.WriteLine(book.Equals(book));
    Console.WriteLine(book.GetHashCode());
    Console.WriteLine(book.GetType());
}

// Q03
{
    // int pages = "464";  -> Compile-time error: cannot implicitly convert string to int.
    int pages = 464;       // Fix (or: int pages = int.Parse("464");)
    Console.WriteLine("Q03: " + pages);
}

// Q04
{
    try
    {
        int zero = 0;
        int result = 10 / zero;
        Console.WriteLine(result);
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Q04: Cannot divide by zero");
    }
    finally
    {
        Console.WriteLine("Done");
    }
}

// Q05 - implicit conversion (int -> double, no data loss)
{
    int pages = 300;
    double pagesDouble = pages;
    Console.WriteLine("Q05: " + pagesDouble);
}

// Q06 - explicit cast (double -> int, decimal part is lost)
{
    double price = 49.99;
    int priceInt = (int)price;
    Console.WriteLine("Q06: " + priceInt); // 49
}

// Q07
{
    string pagesText = "464";
    int pages = Convert.ToInt32(pagesText);
    Console.WriteLine("Q07: " + pages);
}

// Q08
{
    string yearText = "2023";
    int year = int.Parse(yearText);
    Console.WriteLine("Q08: " + year);

    string badText = "abc";
    if (int.TryParse(badText, out int number))
        Console.WriteLine(number);
    else
        Console.WriteLine("Invalid number");
}

// Q09
{
    int pages = 464;
    string pagesText = pages.ToString();
    Console.WriteLine("Q09: " + pagesText + " -> " + pagesText.GetType()); // System.String
}

// Q10
{
    int copies = 100;
    object boxed = copies;       // boxing
    int unboxed = (int)boxed;    // unboxing
    Console.WriteLine("Q10: boxed = " + boxed + ", unboxed = " + unboxed);
}

// Q11
{
    int? year = null;
    Console.WriteLine("Q11: HasValue = " + year.HasValue);
    year = 2023;
    Console.WriteLine("Value = " + year.Value);
}

// Q12
{
    string? reviewer = null;
    Console.WriteLine("Q12: reviewer is null = " + (reviewer == null));
}

// Q13, Q14
{
    Book? book = null;
    string? title = book?.Title; // no crash, title becomes null
    Console.WriteLine("Q13: title = " + (title ?? "null"));

    Console.WriteLine("Q14: " + (title ?? "Untitled"));
    title ??= "Untitled";
    Console.WriteLine("title after ??= : " + title);
}

// Q15
{
    string? name = "Ahmed";
    string confirmedName = name!; // ! tells the compiler "trust me, not null"
    Console.WriteLine("Q15: " + confirmedName);
}

class Book
{
    public string Title { get; set; } = "";
    public int Pages { get; set; }
}