public class Order
{
    private Customer _customer;
    private List<Product> _listOfProducts;
    private string _shippingLabel;
    private string _packingLabel;
    public string CreateShippingLabel()
    {
        return "";
    }
    public string CreatePackkingLabel()
    {
        return "";
    }
    public double GetShippingCost()
    {
        double cost = 0.0;
        //..
        return cost;
    }
    public double GetTotalCost()
    {
        double cost = 0.0;
        //..
        return cost;
    }
    public Order(Customer customer, List<Product> listOfProducts, string shippingLabel, string packingLabel)
    {
        _customer = customer;
        _listOfProducts = listOfProducts;
        _packingLabel = packingLabel;
        _shippingLabel = shippingLabel;
    }
}