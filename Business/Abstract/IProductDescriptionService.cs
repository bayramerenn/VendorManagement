using Core.Utilities.Result;
using Entities.Concrete.VendorManagement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductDescriptionService
    {
        Task<IResult> AddAsync(ProductDescription productDescription);
    }
}
