using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Product_Store.Models;

namespace Product_Store.Repository
{
    public class RepositoryProduct : IProduct

    {

        private ProductEntities productEntities;

        public RepositoryProduct(ProductEntities productEntities)
        {
            this.productEntities = productEntities;
        }

        public void DeleteProduct(int pid)
        {
            Product_Table delemp = productEntities.Product_Table.Find(pid);
            productEntities.Product_Table.Remove(delemp);
            productEntities.SaveChanges();
        }

        public Product_Table getEmpbyid(int pid)
        {
            return productEntities.Product_Table.Find(pid);
        }

        public IEnumerable<Product_Table> getProduct()
        {
            return productEntities.Product_Table.ToList();
        }

        public void InsertEmpRecord(Product_Table emp)
        {
            productEntities.Product_Table.Add(emp);
            productEntities.SaveChanges();
        }

        public void UpdateProduct(Product_Table emp)
        {
            productEntities.Entry(emp).State = System.Data.Entity.EntityState.Modified;
            productEntities.SaveChanges();
        }
    }
}