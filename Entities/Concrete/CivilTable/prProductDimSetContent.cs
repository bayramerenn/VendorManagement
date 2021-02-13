using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.CivilTable
{
    public  class prProductDimSetContent:IEntity
    {
        public string ProductDimSetCode { get; set; }
        public string ItemDim1Code { get; set; }
    }
}
