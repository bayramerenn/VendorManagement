using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete.VendorManagement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductVariantService : IProductVariantService
    {
        private IProductVariantDal _productVariantDal;

        public ProductVariantService(IProductVariantDal productVariantDal)
        {
            _productVariantDal = productVariantDal;
        }

        public async Task<IResult> AddRangeAsync(List<ProductVariant> productVariant)
        {
            await _productVariantDal.AddRangeAsync(productVariant);
            return new SuccessResult();
        }
    }
}
