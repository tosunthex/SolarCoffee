namespace SolarCoffee.Data.Models
{
    public class SalesOrderItem:BaseModel
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}