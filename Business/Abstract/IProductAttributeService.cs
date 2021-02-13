using Core.Utilities.Result;
using Entities.Concrete.VendorManagement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductAttributeService
    {
        Task<IResult> AddAsync(ProductAttribute productAttributes);
        Task<IResult> AddRangeAsync(List<ProductAttribute> productAttributes);
        Task<IDataResult<List<ProductAttribute>>> GetProductAttributes();
    }
}
