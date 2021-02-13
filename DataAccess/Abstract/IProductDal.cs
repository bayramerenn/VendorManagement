using Core.DataAccess;
using Entities.Concrete.CivilTable.Procedure;
using Entities.Concrete.VendorManagement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        public Task<sp_vm_LastProductNumber> sp_LastProductNumber(string productNumber);

    }
}
