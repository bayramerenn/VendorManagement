using Business.Dtos;
using Core.Utilities.Result;
using Entities.Concrete.CivilTable.Procedure;
using Entities.Concrete.VendorManagement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        Task<IResult> AddAsync(ProductCreateDto productCreateDto);
        Task<IDataResult<sp_vm_LastProductNumber>> GetLastProductNumberAsync(string productNumber);
        Task<IDataResult<List<Product>>> GetProductsAsync();

        IResult GetUsers();

    }
}
