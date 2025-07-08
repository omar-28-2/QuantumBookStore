namespace QuantumBookstore.Services
{
    public static class ShippingService
    {
        public static void Send(string address, string bookTitle)
        {
            Console.WriteLine($"Quantum book store > Sending '{bookTitle}' to address: {address}");
        }
    }
}
