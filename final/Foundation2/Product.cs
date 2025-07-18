public class Product
{
    private string _name;
    private int _productID;
    private double _pricePerUnit;
    private int _quantity;
    public double ReturnCost()
    {
        return _pricePerUnit * _quantity;
    }
    public string GetPackingStatement()
    {
        return $"{_productID}: {_name}";
    }
    public Product(string name, int productID, double pricePerUnit, int quantity)
    {
        _name = name;
        _pricePerUnit = pricePerUnit;
        _productID = productID;
        _quantity = quantity;
    }
}