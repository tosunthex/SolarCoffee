using System;

namespace SolarCoffee.Data.Models
{
    public class ProductInventory : BaseModel
    {
        public int QuantityOnHand { get; set; }
        public int IdealQuantity { get; set; }
        public Product Product { get; set; }
    }
}