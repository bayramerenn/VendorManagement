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
    public class ProductColorFabricBlendService : IProductColorFabricBlendService
    {
        private IProductColorFabricBlendDal _productColorFabricBlendDal;

        public ProductColorFabricBlendService(IProductColorFabricBlendDal productColorFabricBlendDal)
        {
            _productColorFabricBlendDal = productColorFabricBlendDal;
        }

        public async Task<IResult> AddRangeAsync(List<ProductColorFabricBlend> productColorFabricBlend)
        {
            await _productColorFabricBlendDal.AddRangeAsync(productColorFabricBlend);
            return new SuccessResult();
        }
    }
}
