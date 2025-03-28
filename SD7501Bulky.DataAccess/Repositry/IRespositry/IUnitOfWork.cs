using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD7501Bulky.DataAccess.Repositry.IRespositry
{
    public interface IUnitOfWork
    {
            ICategoryRepository Category { get; }
            void Save(); 
    }
}
