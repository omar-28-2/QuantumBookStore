namespace QuantumBookstore.Services
{
    public static class MailService
    {
        public static void Send(string email, string bookTitle, string fileType)
        {
            Console.WriteLine($"Quantum book store > Sending '{bookTitle}.{fileType}' to email: {email}");
        }
    }
}
