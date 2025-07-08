namespace QuantumBookstore.Models
{
    public class ShowcaseBook : Book
    {
        public ShowcaseBook(string isbn, string title, string author, int year, double price)
            : base(isbn, title, author, year, price) { }
    }
}
