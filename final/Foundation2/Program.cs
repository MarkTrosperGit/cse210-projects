using System;

class Program
{
    static void Main(string[] args)
    {
        Address MarkTs = new Address("1220 Smith Dr", "Pearland", "TX", "USA");
        Customer MarkT = new Customer("Mark Trosper", MarkTs);
        Product brick = new Product("brick", 32, 0.25, 100);
        Product mortor = new Product("mortor", 23, 0.32, 50);
        Product glass = new Product("glass", 50, 23.00, 5);
        List<Product> mark1list = new List<Product> { brick, mortor, glass };
        Order Mark1 = new Order(MarkT, mark1list);
        Address SethLs = new Address("128 Frank St", "Pearland", "TX", "USA");
        Customer SethL = new Customer("Seth Lyden", SethLs);
        Product flour = new Product("flour", 101, 0.07, 32);
        Product eggs = new Product("eggs", 105, 0.16, 10);
        Product milk = new Product("milk", 104, 0.16, 64);
        List<Product> seth1list = new List<Product> { flour, milk, eggs };
        Order Seth1 = new Order(SethL, seth1list);
        Console.WriteLine(Mark1.CreateShippingLabel() + "\n" + Mark1.CreatePackingLabel());
        Console.WriteLine(Seth1.CreateShippingLabel() + "\n" + Seth1.CreatePackingLabel());
    }
}