namespace CSharpAnonymousTypes;

class Program
{
    static void Main()
    {
        // Must use 'var' - can't write a named type here
        var person = new { Name = "Thomas", Age = 30 }; // Not 'new()', but just 'new'

        string productName = "Laptop";
        decimal price = 999.99m;
        var product = new { productName, price }; // Inferred property names

        // Nested anonymous type
        var order = new
        {
            OrderId = 1,
            Customer = new { Name = "Michael", City = "Seatle" },
            Total = 150.00m
        };
    }
}
