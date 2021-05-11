using System;
using System.Collections.Generic;
using System.Linq;
using SolarCoffee.Data;
using SolarCoffee.Data.Models;

namespace SolarCoffee.Services.Product
{
    public class ProductService:IProductService
    {
        private readonly SolarDbContext _db;

        public ProductService(SolarDbContext dbContext)
        {
            _db = dbContext;
        }

        public List<Data.Models.Product> GetAllProducts()
        {
            return _db.Products.ToList();
        }

        public Data.Models.Product GetProductById(int id)
        {
            return _db.Products.Find(id);
        }

        /// <summary>
        /// Add new products to database
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public ServiceResponse<Data.Models.Product> CreateProduct(Data.Models.Product product)
        {

            try
            {
                _db.Products.Add(product);
                var newInventory = new ProductInventory
                {
                    Product = product,
                    QuantityOnHand = 0,
                    IdealQuantity = 10
                };
                _db.ProductInventories.Add(newInventory);
                _db.SaveChanges();
                return new ServiceResponse<Data.Models.Product>
                {
                    Data = product,
                    IsSuccess = true,
                    Message = "Saved new product",
                    Time = DateTime.Now
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Data.Models.Product>
                {
                    Data = product,
                    IsSuccess = false,
                    Message = "Error saving new product",
                    Time = DateTime.Now
                };
            }
        }
        
        public ServiceResponse<Data.Models.Product> ArchiveProduct(int id)
        {
            
            try
            {
                var product = _db.Products.Find(id);
                product.IsArchived = true;
                _db.SaveChanges();
                return new ServiceResponse<Data.Models.Product>
                {
                    Data = product,
                    IsSuccess = true,
                    Message = "Archived Product",
                    Time = DateTime.Now
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Data.Models.Product>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = e.StackTrace,
                    Time = DateTime.Now
                };
            }
        }
    }
}