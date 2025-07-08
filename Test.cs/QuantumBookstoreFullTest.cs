using System;
using QuantumBookstore.Models;
using QuantumBookstore.Services;

namespace QuantumBookstore.Tests
{
    public static class QuantumBookstoreFullTest
    {
        public static void Run()
        {
            var store = new BookstoreService();

            var paperBook = new PaperBook("1", "Algorithm", "Omar Elhossiny", 2012, 300, 5);
            var ebook = new EBook("2", "Deep Learning", "Hoshos", 2016, 200, "pdf");
            var showcaseBook = new ShowcaseBook("3", "Programming", "Unknown", 1800, 0);

            store.AddBook(paperBook);
            store.AddBook(ebook);
            store.AddBook(showcaseBook);

            store.RemoveOutdatedBooks(100);

            try
            {
                store.BuyBook("1", 2, "Omar@example.com", "11 Zayed St");
                store.BuyBook("2", 1, "Ahmed@example.com", "12 Maddi St");
                store.BuyBook("3", 1, "Mohamed@example.com", "13 Zmalek St");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Quantum book store > ERROR: {ex.Message}");
            }
        }
    }
}
