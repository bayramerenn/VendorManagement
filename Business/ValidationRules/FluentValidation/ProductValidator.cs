using Entities.Concrete.VendorManagement;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ItemCode).NotEmpty();
            RuleFor(p => p.ItemDimTypeCode).NotEmpty();
            RuleFor(p => p.ProductHierarchyId).NotEmpty();
            RuleFor(p => p.UseInternet).NotEmpty();
            RuleFor(p => p.UsePOS).NotEmpty();
            RuleFor(p => p.UseStore).NotEmpty();
            RuleFor(p => p.ItemAccountGrCode).NotEmpty();
            RuleFor(p => p.ItemTaxGrCode).NotEmpty();
            RuleFor(p => p.ProductCollectionGrCode).NotEmpty();
            RuleFor(p => p.StorePriceLevelCode).NotEmpty();
            RuleFor(p => p.CommercialRoleCode).NotEmpty();
            RuleFor(p => p.IsFranchising).Must((o,fr) => { return IsValid(o.LastOrderDate, fr); }).WithMessage("Son siparis tarihi bugunun tarihinden ileri bir tarih olmalı");
            //RuleFor(x => x.UserProfile).Must((o, userProfile) => { return IsValid(o.promoCode, userProfile); })


            RuleFor(p => p.LastOrderDate).NotEmpty();
            RuleFor(p => p.IsCompleted).NotEmpty();
            
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

