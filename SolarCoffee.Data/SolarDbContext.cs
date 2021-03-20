using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SolarCoffee.Data.Models;

namespace SolarCoffee.Data
{
    public class SolarDbContext:IdentityDbContext
    {
        public SolarDbContext()
        {

        }
        public SolarDbContext(DbContextOptions options):base(options){}

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddresses> CustomerAddresseses { get; set; }
    }

    public class CustomerAddresses  
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        [MaxLength(100)]
        public string AddressLine1 { get; set; }
        [MaxLength(100)]
        public string AddressLine2 { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        [MaxLength(50)]
        public string State { get; set; }
        [MaxLength(5)]
        public string PostalCode { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
    }
}