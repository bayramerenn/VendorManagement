using Business.Dtos;
using Core.Utilities.Result;
using Entities.Concrete.VendorManagement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductColorFabricBlendService
    {
        Task<IResult> AddRangeAsync(List<ProductColorFabricBlend> productColorFabricBlend);
    }
}
