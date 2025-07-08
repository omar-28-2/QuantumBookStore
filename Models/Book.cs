namespace QuantumBookstore.Models
{
    public abstract class Book
    {
        public string ISBN { get; }
        public string Title { get; }
        public string Author { get; }
        public int PublishedYear { get; }
        public double Price { get; }

        public Book(string isbn, string title, string author, int year, double price)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            PublishedYear = year;
            Price = price;
        }

        public bool IsOutdated(int maxYears)
        {
            return DateTime.Now.Year - PublishedYear > maxYears;
        }
    }
}
