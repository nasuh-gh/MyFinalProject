using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //Product ile ilgili kurallar
            RuleFor(p => p.ProductName).NotEmpty();//boş olamaz
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();//boş olamaz
            RuleFor(p => p.UnitPrice).GreaterThan(0);//0 dan büyük olmalı
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);//Kategori id si 1 olan ürün fiyatı 10 dan büyük olmalı
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
