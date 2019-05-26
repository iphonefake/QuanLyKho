using BaiVeNhaQuanLyKhoHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Repositories
{

    public interface IBaseEntityRepository<T> where T : BaseEntity
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

        Task SaveAsync();
    }

    public class BaseEntityRepository<T> : IBaseEntityRepository<T> where T : BaseEntity
    {
        protected DataContext db { get; set; }
        //DataContext db = new DataContext();
        public BaseEntityRepository(DataContext _db){
            db = _db;
        }

        public void Create(T entity)
        {
            this.db.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            this.db.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return this.db.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.db.Set<T>().Where(expression);
        }

        public async Task SaveAsync()
        {
            await this.db.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            this.db.Set<T>().Update(entity);
        }

        
    }
}
