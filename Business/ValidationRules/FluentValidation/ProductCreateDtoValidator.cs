using Business.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductCreateDtoValidator:AbstractValidator<ProductCreateDto>
    {
        public ProductCreateDtoValidator()
        {
            //Product
            RuleFor(p => p.Product.ItemCode).NotEmpty();
            RuleFor(p => p.Product.ItemDimTypeCode).NotEmpty();
            RuleFor(p => p.Product.ProductHierarchyId).NotEmpty();
            RuleFor(p => p.Product.UseInternet).NotEmpty();
            RuleFor(p => p.Product.UsePOS).NotEmpty();
            RuleFor(p => p.Product.UseStore).NotEmpty();
            RuleFor(p => p.Product.ItemAccountGrCode).NotEmpty();
            RuleFor(p => p.Product.ItemTaxGrCode).NotEmpty();
            RuleFor(p => p.Product.ProductCollectionGrCode).NotEmpty();
            RuleFor(p => p.Product.StorePriceLevelCode).NotEmpty();
            RuleFor(p => p.Product.CommercialRoleCode).NotEmpty();
            RuleFor(p => p.Product.IsFranchising).Must((o, fr) => { return IsValid(o.Product.LastOrderDate, fr); }).WithMessage("Son siparis tarihi bugünün tarihinden ileri bir tarih olmalı");
            RuleFor(p => p.Product.LastOrderDate).NotEmpty();
            RuleFor(p => p.Product.IsCompleted).NotEmpty();
            RuleFor(p => p.Product.CreatedDate).NotEmpty();
            RuleFor(p => p.Product.LastUpdatedDate).NotEmpty();
            RuleFor(p => p.Product.CreatedUserName).NotEmpty();
            RuleFor(p => p.Product.LastUpdatedUserName).NotEmpty();

            //ProductDescription
            RuleFor(p => p.ProductDescription.ItemCode).NotEmpty();
            RuleFor(p => p.ProductDescription.ItemDescription).NotEmpty();
            RuleFor(p => p.ProductDescription.ItemDescription).Length(5,200);
            RuleFor(p => p.ProductDescription.LastUpdatedDate).NotEmpty();
            RuleFor(p => p.ProductDescription.LastUpdatedUserName).NotEmpty();
            RuleFor(p => p.ProductDescription.CreatedDate).NotEmpty();
            RuleFor(p => p.ProductDescription.CreatedUserName).NotEmpty();

            //ProductAttribute
            RuleFor(p => p.ProductAttributes).NotNull();
            RuleForEach(p => p.ProductAttributes).ChildRules(child =>
            {
                child.RuleFor(x => x.ItemCode).NotEmpty();
                child.RuleFor(x => x.AttributeTypeCode).NotEmpty();
                child.RuleFor(x => x.AttributeCode).NotEmpty();
                child.RuleFor(x => x.CreatedDate).NotEmpty();
                child.RuleFor(x => x.CreatedUserName).NotEmpty();
                child.RuleFor(x => x.LastUpdatedDate).NotEmpty();
                child.RuleFor(x => x.LastUpdatedUserName).NotEmpty();
            });
        }

        private bool IsValid(DateTime lastOrderDate, bool fr)
        {
            if (fr && DateTime.Now > lastOrderDate)
            {
                return false;
            }
            return true;
        }
    }
}
