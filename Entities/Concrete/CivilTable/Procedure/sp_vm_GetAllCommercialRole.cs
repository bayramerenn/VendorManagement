using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.CivilTable.Procedure
{
    public class sp_vm_GetAllCommercialRole:IEntity
    {
        public byte CommercialRoleCode { get; set; }
        public string CommercialRoleDescription { get; set; }
    }
}
