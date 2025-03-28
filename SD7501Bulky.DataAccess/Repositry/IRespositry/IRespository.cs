using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SD7501Bulky.DataAccess.Repositry.IRespositry
{
    public interface IRespository<T> where T : class
    {
        //T - Category
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> fitler);
        void Add(T enitity);
        void Remove(T enitity);
        void RemoveRnage(IEnumerable<T> enitity);
    }
}
