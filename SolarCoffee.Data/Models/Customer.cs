using System;

namespace SolarCoffee.Data.Models
{
    public class Customer:BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CustomerAddresses PrimaryAddresses { get; set; }
    }
}