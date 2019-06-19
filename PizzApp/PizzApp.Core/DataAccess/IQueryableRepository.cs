using PizzApp.Core.Entities;
using System.Linq;

namespace PizzApp.Core.DataAccess
{
    /// <summary>
    /// IQueryable operasyonların (özellikle business'da) çalıştırılabilmesi için (context kapanmadan çalıştırılabilmesi için) 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IQueryableRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}