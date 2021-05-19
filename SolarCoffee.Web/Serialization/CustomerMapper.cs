using System;
using System.ComponentModel.DataAnnotations;
using SolarCoffee.Data.Models;
using SolarCoffee.Web.ViewModels;

namespace SolarCoffee.Web.Serialization
{
    public class CustomerMapper
    {

        /// <summary>
        /// Serialize a Customer data model into a CustomerModel
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static CustomerModel SerializeCustomer(Customer customer)
        {
            var address = MapCustomerAddress(customer.PrimaryAddresses);

            return new CustomerModel
            {
                Id = customer.Id,
                CreatedOn = customer.CreatedOn,
                PrimaryAddresses = address,
                LastName = customer.LastName,
                FirstName= customer.FirstName,
                UpdatedOn = customer.UpdatedOn
            };
        }

        /// <summary>
        /// Serialize CustomerAddresses data model into CustomerAdressModel
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static CustomerAddressModel MapCustomerAddress(CustomerAddresses address)
        {
            return new CustomerAddressModel
            {
                UpdatedOn = address.UpdatedOn,
                Id = address.Id,
                AddressLine1 = address.AddressLine1,
                AddressLine2 = address.AddressLine2,
                City = address.City,
                State = address.State,
                Country = address.Country,
                PostalCode = address.PostalCode,
                CreatedOn = address.CreatedOn
            };
        }

        /// <summary>
        /// Serialize a CustomerAddressModel into a CustomerAddresses
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static CustomerAddresses MapCustomerAddress(CustomerAddressModel address)
        {
            return new CustomerAddresses
            {
                UpdatedOn = address.UpdatedOn,
                Id = address.Id,
                AddressLine1 = address.AddressLine1,
                AddressLine2 = address.AddressLine2,
                City = address.City,
                State = address.State,
                Country = address.Country,
                PostalCode = address.PostalCode,
                CreatedOn = address.CreatedOn
            };
        }

        /// <summary>
        /// Serialize CustomerModel into Customer data model
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static Customer SerializeCustomer(CustomerModel customer)
        {
            var address = MapCustomerAddress(customer.PrimaryAddresses);

            return new Customer
            {
                Id = customer.Id,
                CreatedOn = customer.CreatedOn,
                PrimaryAddresses = address,
                LastName = customer.LastName,
                FirstName = customer.FirstName,
                UpdatedOn = customer.UpdatedOn
            };
        }

    }
}