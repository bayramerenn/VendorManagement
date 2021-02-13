using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.CivilTable.Procedure
{
   public class sp_vm_GetAllProductPartType:IEntity
    {
        public string ProductPartCode { get; set; }
        public string ProductPartDescription { get; set; }
    }
}
