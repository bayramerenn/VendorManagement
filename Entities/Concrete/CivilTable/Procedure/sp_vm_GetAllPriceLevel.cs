using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.CivilTable.Procedure
{
    public class sp_vm_GetAllPriceLevel:IEntity
    {
        public byte StorePriceLevelCode { get; set; }
        public string StorePriceLevelDescription { get; set; }
    }
}
