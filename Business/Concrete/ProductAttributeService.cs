using Business.Abstract;
using Business.Contants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete.VendorManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductAttributeService : IProductAttributeService
    {
        private IProductAttributeDal _productAttributeDal;

        public ProductAttributeService(IProductAttributeDal productAttributeDal)
        {
            _productAttributeDal = productAttributeDal;
        }

        public async Task<IResult> AddAsync(ProductAttribute productAttributes)
        {

            await _productAttributeDal.AddAsync(productAttributes);

            return new SuccessResult(Messages.ProductDescriptionAdded);

        }

        public async Task<IResult> AddRangeAsync(List<ProductAttribute> productAttributes)
        {
            await _productAttributeDal.AddRangeAsync(productAttributes);

            return new SuccessResult(Messages.ProductDescriptionAdded);
        }

        public async Task<IDataResult<List<ProductAttribute>>> GetProductAttributes()
        {
            var result = await _productAttributeDal.GetListAsync();
            return new SuccessDataResult<List<ProductAttribute>>(result.ToList());
        }
    }
}
