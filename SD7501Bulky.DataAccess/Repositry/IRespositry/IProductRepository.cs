using BulkyWeb.Models;
using SD7501Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD7501Bulky.DataAccess.Repositry.IRespositry
{
    public interface IProductRepository:IRespository<Product>

    {
        void Update(Product obj);
    }
}
