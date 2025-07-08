namespace QuantumBookstore.Models
{
    public class EBook : Book
    {
        public string FileType { get; }

        public EBook(string isbn, string title, string author, int year, double price, string fileType)
            : base(isbn, title, author, year, price)
        {
            FileType = fileType;
        }
    }
}
