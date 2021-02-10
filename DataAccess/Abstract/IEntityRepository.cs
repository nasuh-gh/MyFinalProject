using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //T ye filtre getirdik
    //generic consraint-generik kısıt-Buradaki T yi sınırlandıracağız.
    //class: demek T referans tip olur demek.
    //virgülle birlikte T ya IEntity olabilir ya da IEntitiy den imlemente olan bir nesne olabilir
    //new(): T new lenebilir olmalı demek. IEntity interface olduğu için new lenemez. T soyut bir nesne olmamalı
    //DİKKAT: Syntax ın avantajlarını kullandık. IEntity ürüleri tek bir noktada bağlamamıza neden oldu. Sadece Ientity yazarak Category,Customer,Product u ifade edebiliyoruz.

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//T ye Product dediysek Ürünleri listele-T ye Category dediysek kateorileri listele-Filtrelenmemiş şekilde liseleyecek
        T Get(Expression<Func<T, bool>> filter);//Ürünleri filtreye göre listele
        void Add(T entity);//T Product ise Ürün ekle gibi
        void Update(T entity);
        void Delete(T entity);

    }
}
