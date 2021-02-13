using Core.DataAccess;
using Entities.Concrete.CivilTable;
using Entities.Concrete.CivilTable.Procedure;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductHierarchyDal : IEntityRepository<ProductHierarchy>
    {
        public Task<IList<sp_vm_GetProductDimSetByHierarchyId>> GetProductDimSetByHierarchyId(int productHiearchyId);
        public Task<IList<sp_vm_GetAllAttributeByHierarchyId>> GetAllAttributeByHierarchyId(int productHiearchyId);
        public Task<IList<sp_vm_GetAttrContentsByHiearIdandAttrCode>> GetAttrContentsByHierarchyIdandAttrCode(int productHiearchyId,int AttributeTypeCode);
        public Task<IList<sp_vm_GetAllFabricType>> GetAllFabricType();
        public Task<IList<sp_vm_GetAllProductPartType>> GetAllProductPartType();
        public Task<IList<sp_vm_GetAllPriceLevel>> sp_vm_GetAllPriceLevel();
        public Task<IList<sp_vm_GetAllCommercialRole>> sp_vm_GetAllCommercialRole();
        public Task<IList<ProductHierarchy>> GetAllHierarchy();
      
    }
}
