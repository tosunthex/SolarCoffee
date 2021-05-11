using SolarCoffee.Web.ViewModels;

namespace SolarCoffee.Web.Serialization
{
    public class ProductMapper
    {
        /// <summary>
        /// Maps a product data model to a ProductModel view model
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public static ProductModel SerializeProductModel(Data.Models.Product product)
        {
            return new ProductModel
            {
                Id = product.Id,
                CreatedOn   = product.CreatedOn,
                Description = product.Description,
                IsArchived = product.IsArchived,
                IsTaxable = product.IsTaxable,
                Name = product.Name,
                Price = product.Price,
                UpdatedOn = product.UpdatedOn
            };
        }

        /// <summary>
        /// Maps a ProductModel view model to a Product data model
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public static Data.Models.Product SerializeProductModel(ProductModel product)
        {
            return new Data.Models.Product
            {
                Id = product.Id,
                CreatedOn = product.CreatedOn,
                Description = product.Description,
                IsArchived = product.IsArchived,
                IsTaxable = product.IsTaxable,
                Name = product.Name,
                Price = product.Price,
                UpdatedOn = product.UpdatedOn
            };
        }
    }
}