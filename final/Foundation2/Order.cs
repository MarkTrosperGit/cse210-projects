public class Order
{
    private Customer _customer;
    private List<Product> _listOfProducts;
    private string _shippingLabel;
    private string _packingLabel;
    public string CreateShippingLabel()
    {

        return _customer.GetNameAndAddress();
    }
    public string CreatePackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _listOfProducts)
        {
            packingLabel += $"{product.GetPackingStatement()}\n";
        }
        return packingLabel;
    }
    public double GetShippingCost()
    {
        if (_customer.InUS() == true)
        {
            return 5.0;
        }
        else
        {
            return 35.0;
        }
    }
    public double GetTotalCost()
    {
        double cost = 0.0;
        foreach (Product product in _listOfProducts)
        {
            cost += product.ReturnCost();
        }
        cost += GetShippingCost();
        return cost;
    }
    public Order(Customer customer, List<Product> listOfProducts)
    {
        _customer = customer;
        _listOfProducts = listOfProducts;
        _packingLabel = CreatePackingLabel();
        _shippingLabel = CreateShippingLabel();
    }
}