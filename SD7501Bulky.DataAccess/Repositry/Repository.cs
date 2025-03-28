using BulkyWeb.Data;
using Microsoft.EntityFrameworkCore;
using SD7501Bulky.DataAccess.Repositry.IRespositry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SD7501Bulky.DataAccess.Repositry
{
    public class Repository<T> : IRespository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbset;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbset = _db.Set<T>();
        }
        void IRespository<T>.Add(T enitity)
        {
            dbset.Add(enitity);
        }

        T IRespository<T>.Get(Expression<Func<T, bool>> fitler)
        {
            IQueryable<T> query = dbset;
            query = query.Where(fitler);
            return query.FirstOrDefault();
        }

        IEnumerable<T> IRespository<T>.GetAll()
        {
            IQueryable<T> query = dbset;
            return query.ToList();
        }

        void IRespository<T>.Remove(T enitity)
        {
            dbset.Remove(enitity);
        }

        void IRespository<T>.RemoveRnage(IEnumerable<T> enitity)
        {
            dbset.RemoveRange(enitity);
        }
    }
}
