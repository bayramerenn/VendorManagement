using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete.CivilTable.Procedure
{
    public class sp_vm_GetProductDimSetByHierarchyId:IEntity
    {
        
        public int ProductHierarchyId { get; set; }
        public string ProductDimSetCode { get; set; }
        public string ProductDimSetDescription { get; set; }
    }
}
