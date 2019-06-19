using PizzApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzApp.Core.DataAccess.NHibernate
{
    public class NhQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private NHibernateHelper _nHibernateHelper;

        private IQueryable<T> _entities; //bundan sonra Table'a return.
        public NhQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }
        //public IQueryable<T> Table => throw new NotImplementedException();
        public IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }

        }

        public virtual IQueryable<T> Entities //_entities dönecek
        {
            get
            {
                if (_entities == null)
                {
                    //tüm nesneye abone
                    _entities = _nHibernateHelper.OpenSession().Query<T>();
                }
                return _entities;
            }


        }
    }
}
