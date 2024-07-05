namespace InventoryManagement
{
    public class Price
    {
public double ItemPrice { get; set; }
public Currency Currency { get; set; }

        public override string ToString()
        {
            return  $"{ItemPrice} {Currency}";
        }
//constructor
/*public Price(double price, Currency currency)
{

    ItemPrice = price;
    Currency = currency;
} */

    }


}