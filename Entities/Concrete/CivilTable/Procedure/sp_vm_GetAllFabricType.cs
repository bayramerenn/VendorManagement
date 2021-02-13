using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.CivilTable.Procedure
{
    public class sp_vm_GetAllFabricType:IEntity
    {
        public string FabricCode { get; set; }
        public string FabricDescription { get; set; }
    }
}
