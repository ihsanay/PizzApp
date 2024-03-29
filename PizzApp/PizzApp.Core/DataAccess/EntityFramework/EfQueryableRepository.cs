﻿using PizzApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzApp.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private DbContext _context;
        IDbSet<T> _entities;
        public EfQueryableRepository(DbContext context)
        {
            _context = context;
        }
        //Tablo, DbSet'e karşılık geliyor. Bir tabloya abone olup, o tablo uzerinden queryable yapmamızı sağlayacak.
        public IQueryable<T> Table { get; }

        //virtual - lazy loading yapabilmek için, protected - başka sınıflar kullanmayacak.
        protected virtual IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<T>();
                }
                return _entities;
            }
        }
    }
}
