using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product_Store.Models;

namespace Product_Store.Repository
{
    public interface IProduct
    {
        void InsertEmpRecord(Product_Table emp);
        IEnumerable<Product_Table> getProduct();
        void UpdateProduct(Product_Table emp);
        void DeleteProduct(int pid);
        Product_Table getEmpbyid(int pid);
    }
}
