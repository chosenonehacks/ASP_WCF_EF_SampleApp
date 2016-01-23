using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : IProductService
    {
        private SampleDbEntities _dbEntities = new SampleDbEntities();

        public List<Product> GetAllProducts()
        {
            return _dbEntities.Products.ToList();
        }

        public List<Product> GetProductsByDate(DateTime creationDate)
        {
            return _dbEntities.Products.Where(p => p.CreationDate == creationDate).ToList();
        }

        public List<Product> GetProductsById(int id)
        {
            return _dbEntities.Products.Where(p => p.Id == id).ToList();
        }
    }
}
