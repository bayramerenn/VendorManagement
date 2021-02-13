using Core.Utilities.Result;
using Entities.Concrete.CivilTable;
using Entities.Concrete.CivilTable.Procedure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductHierarchyService
    {
        Task<IDataResult<List<ProductHierarchy>>> GetAllHierarchy();
        Task<IDataResult<List<sp_vm_GetProductDimSetByHierarchyId>>> GetProductDimSetByHierarchyId(int productHiearchyId);
        Task<IDataResult<List<sp_vm_GetAllAttributeByHierarchyId>>> GetAllAttributeByHierarchyId(int productHiearchyId);
        Task<IDataResult<List<sp_vm_GetAttrContentsByHiearIdandAttrCode>>> GetAttrContentsByHierarchyIdandAttrCode(int productHiearchyId, int AttributeTypeCode);
        public Task<IDataResult<List<sp_vm_GetAllFabricType>>> GetAllFabricType();
        public Task<IDataResult<List<sp_vm_GetAllProductPartType>>> GetAllProductPartType();
        public Task<IDataResult<List<sp_vm_GetAllPriceLevel>>> GetAllPriceLevel();
        public Task<IDataResult<List<sp_vm_GetAllCommercialRole>>> GetAllCommercialRole();
      
    }
}
