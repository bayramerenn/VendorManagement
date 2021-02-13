using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete.CivilTable.Procedure
{
    public class sp_vm_GetAllAttributeByHierarchyId:IEntity
    {
        [Key]
        public byte AttributeTypeCode { get; set; }
        public string AttributeTypeDescription { get; set; }
        public bool IsRequired { get; set; }
    }
}
