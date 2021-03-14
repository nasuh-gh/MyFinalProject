using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //IDataResult ı koyarak işlem sonucu ve mesaj da ekledik-Data olanlar
        //Bizim T miz List<Product> bu
        IDataResult<List<Product>> GetAll();//ürün listesi döndür
        IDataResult<List<Product>> GetAllByCategoryId(int id);//Kategori id ye göre getir
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);//Ürün fiyat aralığına göre getir
        IDataResult<List<ProductDetailDto>> GetProductDetails();//Ürün detay listesi
        //Burdaki T miz Product
        IDataResult<Product> GetById(int productId);//Tek başına bir ürün döndürüyor
        //IResult ı koyarak sadece işlem sonucu ve mesaj ekledik
        //Sonuç true ise ekler ve mesaj(isteğe bağlı), sonuç false ise eklemez ve mesaj(isteğe bağlı)-Data olmadığı için IResult
        IResult Add(Product product);
        IResult Update(Product product);

    }
}
