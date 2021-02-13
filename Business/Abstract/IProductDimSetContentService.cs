using Core.Utilities.Result;
using Entities.Concrete.CivilTable;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductDimSetContentService
    {
        Task<IDataResult<List<prProductDimSetContent>>> GetListAsync(string productDimSetCode);
    }
}
