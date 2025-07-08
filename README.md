# 📚 Quantum Bookstore

An extensible online bookstore system built in C# for the **Fawry N² Dev Slope #10 Challenge**.

This system supports different types of books — including paper books, eBooks, and showcase/demo books — with full support for adding, removing, and purchasing books.

> ✅ All output messages are prefixed with: `Quantum book store > ...`

---

## 🧩 Features

- 📘 Add books to inventory:
  - Paper books (stocked & shippable)
  - eBooks (with file type, sent via email)
  - Showcase books (not for sale)
  
- 🗑️ Remove outdated books by a given age threshold

- 💰 Buy books using their ISBN:
  - Automatically reduce stock (for paper books)
  - Reject demo books from being sold
  - Trigger shipping or email services depending on book type

- 🧪 Full test suite included in `QuantumBookstoreFullTest`

---

## 📦 Project Structure

```
QuantumBookstore/
├── Models/           # Book types and inheritance
│   ├── Book.cs
│   ├── PaperBook.cs
│   ├── EBook.cs
│   └── ShowcaseBook.cs
│
├── Services/         # System behavior & services
│   ├── BookstoreService.cs
│   ├── ShippingService.cs
│   └── MailService.cs
│
├── Tests/            # Manual test cases
│   └── QuantumBookstoreFullTest.cs
│
├── Program.cs        # App entry point
├── QuantumBookstore.csproj
└── README.md
```

---

## 🚀 How to Run

1. Clone the repo:

```bash
git clone https://github.com/omar-28-2/QuantumBookstore.git
cd QuantumBookstore
```

2. Build and run:

```bash
dotnet run
```

You’ll see printed results of test cases and actions.

---

## 🖼️ Output Screenshot

> You can add an image here showing console output after running the program:

```
Quantum book store > Removed outdated book: Ancient Manuscript
Quantum book store > Sending 'Clean Code' to address: 123 Main St
Quantum book store > Sold 2x Clean Code for 600
Quantum book store > Sending 'Deep Learning.pdf' to email: user@example.com
Quantum book store > Sold 1x Deep Learning for 200
Quantum book store > ERROR: This book is not for sale.
```

👉 **Add your image here**:
```markdown
![Console Output](screenshots/output-example.png)
```

---

## 🧪 Test Scenarios

`QuantumBookstoreFullTest` simulates:

- Adding different types of books
- Removing a book older than 100 years
- Purchasing:
  - A paper book (with stock control)
  - An eBook (with file type and email delivery)
  - A showcase book (throws error)

---

## 🔧 Tech Stack

- Language: C#
- Framework: .NET 7 / .NET 6 (works with any recent SDK)
- Design: Object-Oriented Programming, Extensible Architecture

---

## 📚 Future Improvements

- Persist inventory to database or file
- Unit tests using xUnit or NUnit
- GUI or Web API interface
- Order history tracking
- Authentication system for customers

---

## 📄 License

MIT License. See `LICENSE` file.

---

## 🙌 Author

Made with ❤️ by **Omar Elhossiny** as part of the **Fawry Rise Dev Challenge**.
