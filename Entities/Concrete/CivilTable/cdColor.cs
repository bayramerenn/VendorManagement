using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete.CivilTable
{
    public class cdColor:IEntity
    {
        [Key]
        public string ColorCode { get; set; }
        public string ColorHex { get; set; }
    }
}
