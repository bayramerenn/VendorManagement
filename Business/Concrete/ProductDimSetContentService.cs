using Business.Abstract;
using Business.Contants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete.CivilTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductDimSetContentService : IProductDimSetContentService
    {
        public IProductDimSetContentDal _productDimSetContentDal;

        public ProductDimSetContentService(IProductDimSetContentDal productDimSetContentDal)
        {
            _productDimSetContentDal = productDimSetContentDal;
        }

        public async Task<IDataResult<List<prProductDimSetContent>>> GetListAsync(string productDimSetCode)
        {
            try
            {
                var result = await _productDimSetContentDal.GetListAsync(x => x.ProductDimSetCode == productDimSetCode);
                return new SuccessDataResult<List<prProductDimSetContent>>(result.ToList());
            }
            catch(Exception e) 
            {

                return new ErrorDataResult<List<prProductDimSetContent>>(Messages.ErrorData + e.Message);
            }
        }
    }
}
