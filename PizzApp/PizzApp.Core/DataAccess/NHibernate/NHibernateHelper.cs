using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzApp.Core.DataAccess.NHibernate
{
    public abstract class NHibernateHelper : IDisposable
    {

        private static ISessionFactory _sessionFactory;
        //factory design pattern'den besleniyor. Oracle için configuration gönderildiğinde, oracle için session oluşturacak. Sql server için gönderildiğinde onun için...

        //virtual - lazy loading veya navigation property bir nesnede, o nesnenin ilişkili nesnelerini getirmek gibi durumlar için.
        public virtual ISessionFactory SessionFactory
        {
            get { return _sessionFactory ?? (_sessionFactory = InitializeFactory()); }
        }

        //NHibernateHelper'ı kim kullanacaksa, ona şunu demek lazım: bir session factory implementasyonu gerçekleştir. Ben onu kullanayım. Burada da bir nevi dependency injection gibi düşünülebilir. Dolayısıyla, bunu kullanacak kişi, ezeceğine göre, NHibernateHelper'ı implement ettiğinde hepsinin ayrı ayrı implement etmesi için abstract bir metod yazmak lazım. (Sadece implemente eden kullansın diye protected)
        protected abstract ISessionFactory InitializeFactory();

        public virtual ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
