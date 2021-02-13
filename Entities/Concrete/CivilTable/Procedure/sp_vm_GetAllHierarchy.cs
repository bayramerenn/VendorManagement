using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.CivilTable.Procedure
{
    public class sp_vm_GetAllHierarchy:IEntity
    {
        public int Id { get; set; }
        public string Gender { get; set; }
        public string MainGroup { get; set; }
        public string Category { get; set; }
        public string ItemAccountGrCode { get; set; }
        public string ItemTaxGrCode { get; set; }
    }
}
