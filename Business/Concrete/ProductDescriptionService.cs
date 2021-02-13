using Business.Abstract;
using Business.Contants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete.VendorManagement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductDescriptionService : IProductDescriptionService
    {
        private IProductDescriptionDal _productDescriptionDal;

        public ProductDescriptionService(IProductDescriptionDal productDescriptionDal)
        {
            _productDescriptionDal = productDescriptionDal;
        }

        public async Task<IResult> AddAsync(ProductDescription productDescription)
        {
            await _productDescriptionDal.AddAsync(productDescription);

            return new SuccessResult(Messages.ProductDescriptionAdded);
        }
    }
}
