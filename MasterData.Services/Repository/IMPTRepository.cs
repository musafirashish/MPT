﻿using System.Collections.Generic;
using System.Linq;

namespace MasterData.Services.Repository
{
    public interface IMPTRepository
    {
        IQueryable<T> GetAll<T>() where T : class;
        T Get<T>(int id) where T : class;
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
    }
}
