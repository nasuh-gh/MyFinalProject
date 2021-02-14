using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Loosely coupled-Gevşek bağlılık-bir bağlılık var ama soyuta bağlılık var-o servis değişirse bir problemle karşılaşmayacağız
        //naming convention-isimlendirme standardı
        //IoC Container-Inversion of Control-Değişimin kontrolü
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            //Dependency chain-Bağımlılık zinciri
            //IProductService bir ProductManager e ihtiyaç duyuyor, ProductManager de bir EfProductDal a ihtiyaç duyuyor
            //Alttaki satırda bağımlılık zinciri var-bunu düzeltmek için en yukarda constructor yaptık -injaction
            //IProductService productService = new ProductManager(new EfProductDal());
            //Bu sayfa bizim API miz ve dal veya business somut sınıfını görmüyoruz.
            //ProductManager de de herhangi bir dal görmüyoruz soyut dışında
            //Şuan sistemde hiçbir katman diğerini new lemiyor veya somut sınıf üzerinden gitmiyoruz***
            var result = _productService.GetAll();
            return result.Data;
        }
    }
}
