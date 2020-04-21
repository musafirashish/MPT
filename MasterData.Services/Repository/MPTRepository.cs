using MasterData.Services.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterData.Services.Repository
{
    public class MPTRepository : IMPTRepository
    {
        private readonly MPTContext _mptContext;

        public MPTRepository(MPTContext mptContext)
        {
            _mptContext = mptContext;
        }

        public T Get<T>(int id) where T : class
        {
            return _mptContext.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            return _mptContext.Set<T>();
        }

        public void Add<T>(T entity) where T : class
        {
            _mptContext.Set<T>().Add(entity);
            _mptContext.SaveChanges();
        }
        public void Update<T>(T entity) where T : class
        {
            _mptContext.Set<T>().Attach(entity);
            _mptContext.Entry(entity).State = EntityState.Modified;
            _mptContext.SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            _mptContext.Remove(entity);
            _mptContext.SaveChanges();

        }
    }
}
