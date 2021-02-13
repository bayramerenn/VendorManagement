using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.CivilTable.Procedure
{
    public class sp_vm_GetAttrContentsByHiearIdandAttrCode:IEntity
    {
        public string AttributeCode { get; set; }
        public string AttributeDescription { get; set; }
    }
}
