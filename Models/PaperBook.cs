namespace QuantumBookstore.Models
{
    public class PaperBook : Book
    {
        public int Quantity { get; set; }

        public PaperBook(string isbn, string title, string author, int year, double price, int quantity)
            : base(isbn, title, author, year, price)
        {
            Quantity = quantity;
        }
    }
}