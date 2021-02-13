using Core.DataAccess.EfEntityFramework;
using Core.Dto.CivilDto;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete.CivilTable;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.CivilDal
{
    public class EfCdColorDal : EfEntityRepository<cdColor, CivilContext>, ICdColorDal
    {
        public async Task<List<ColorDescDto>> GetColorByColorCode()
        {
            using (var context = new CivilContext())
            {
                var result = from color in context.CdColor
                             join colorDesc in context.CdColorDesc
                             on color.ColorCode equals colorDesc.ColorCode
                             where colorDesc.LangCode == "TR"
                             select new ColorDescDto { ColorCode = color.ColorCode,ColorHex= color.ColorHex,ColorDescription=colorDesc.ColorDescription };

                     return await result.ToListAsync();
                             
           }
        }
    }
}
