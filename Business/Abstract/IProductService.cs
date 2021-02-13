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
        List<Product> GetAll();//ürün listesi döndür
        List<Product> GetAllByCategoryId(int id);//Kategori id ye göre getir
        List<Product> GetByUnitPrice(decimal min, decimal max);//Ürün fiyat aralığına göre getir
        List<ProductDetailDto> GetProductDetails();//Ürün detay listesi
        Product GetById(int productId);//Tek başına bir ürün döndürüyor
        IResult Add(Product product);

    }
}
