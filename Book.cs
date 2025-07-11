using System;
namespace HELLOWORLD
{
    public class Book
{
    // Private fields
    private string isbn;
    private string title;
    private string author;
    private int pages;
    private bool isAvailable;
    private DateTime publishDate;
    
    // Static field - barcha kitoblar soni
    private static int totalBooks = 0;
    
    // Constructor
    public Book(string isbn, string title, string author, int pages, DateTime publishDate)
    {
        this.isbn = isbn;
        this.title = title;
        this.author = author;
        this.pages = pages;
        this.publishDate = publishDate;
        this.isAvailable = true;
        totalBooks++;
    }
    
    // Properties
    public string ISBN 
    { 
        get { return isbn; } 
        // ISBN o'zgarmasligi uchun set yo'q
    }
    
    public string Title
    {
        get { return title; }
        set 
        { 
            if (!string.IsNullOrEmpty(value))
                title = value;
        }
    }
    
    public string Author
    {
        get { return author; }
        set 
        { 
            if (!string.IsNullOrEmpty(value))
                author = value;
        }
    }
    
    public int Pages
    {
        get { return pages; }
        set 
        { 
            if (value > 0)
                pages = value;
        }
    }
    
    public bool IsAvailable
    {
        get { return isAvailable; }
        private set { isAvailable = value; }
    }
    
    public DateTime PublishDate 
    { 
        get { return publishDate; } 
    }
    
    // Computed property
    public int BookAge
    {
        get { return DateTime.Now.Year - publishDate.Year; }
    }
    
    // Static property
    public static int TotalBooks
    {
        get { return totalBooks; }
    }
    
    // Methods
    public bool Borrow(string borrowerName)
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine($"'{title}' kitob {borrowerName}ga berildi.");
            return true;
        }
        else
        {
            Console.WriteLine($"'{title}' kitob mavjud emas.");
            return false;
        }
    }
    
    public void Return()
    {
        if (!isAvailable)
        {
            isAvailable = true;
            Console.WriteLine($"'{title}' kitob qaytarildi.");
        }
        else
        {
            Console.WriteLine($"'{title}' kitob allaqachon mavjud.");
        }
    }
    
    public string GetBookInfo()
    {
        return $"ISBN: {isbn}\nNomi: {title}\nMuallif: {author}\n" +
               $"Sahifalar: {pages}\nNashr yili: {publishDate.Year}\n" +
               $"Holati: {(isAvailable ? "Mavjud" : "Olingan")}";
    }
    
    // Static method
    public static void PrintTotalBooks()
    {
        Console.WriteLine($"Jami kitoblar soni: {totalBooks}");
    }
    
    // ToString override
    public override string ToString()
    {
        return $"{title} - {author}";
    }
}
}