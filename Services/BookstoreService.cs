using System;
using System.Collections.Generic;
using QuantumBookstore.Models;

namespace QuantumBookstore.Services
{
    public class BookstoreService
    {
        private Dictionary<string, Book> inventory = new();

        public void AddBook(Book book)
        {
            if (inventory.ContainsKey(book.ISBN))
            {
                throw new ArgumentException($"A book with ISBN {book.ISBN} already exists in the inventory.");
            }
            else
            {
                inventory[book.ISBN] = book;
            }
        }

        public List<Book> RemoveOutdatedBooks(int CurrentYear)
        {
            List<Book> removed = new();
            foreach (var book in inventory.Values)
            {
                if (book.IsOutdated(CurrentYear))
                {
                    removed.Add(book);
                }
            }

            foreach (var book in removed)
            {
                inventory.Remove(book.ISBN);
                Console.WriteLine($"Quantum book store > Removed outdated book: {book.Title}");
            }

            return removed;
        }

        public double BuyBook(string isbn, int quantity, string email, string address)
        {
            if (!inventory.ContainsKey(isbn))
            {
                throw new ArgumentException($"No book found with ISBN {isbn}.");
            }

            Book book = inventory[isbn];

            if (book is ShowcaseBook)
            {
                throw new Exception("This book is not for sale.");
            }

            if (book is PaperBook paper)
            {
                if (paper.Quantity < quantity)
                {
                    throw new Exception($"Not enough stock for {paper.Title}. Available: {paper.Quantity}, Requested: {quantity}");
                }
                paper.Quantity -= quantity;
                ShippingService.Send(address, paper.Title);
                double total = paper.Price * quantity;
                Console.WriteLine($"Quantum book store > Sold {quantity}x {paper.Title} for {total}");
                return total;
            }
            else if (book is EBook ebook)
            {
                MailService.Send(email, ebook.Title, ebook.FileType);
                Console.WriteLine($"Quantum book store > Sold 1x {ebook.Title} for {ebook.Price}");
                return ebook.Price;
            }

            throw new Exception("Unknown book type.");
        }
        

    }
}