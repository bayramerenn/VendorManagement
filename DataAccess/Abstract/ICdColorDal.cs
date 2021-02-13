using Core.DataAccess;
using Core.Dto.CivilDto;
using Entities.Concrete.CivilTable;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICdColorDal:IEntityRepository<cdColor>
    {
        public Task<List<ColorDescDto>> GetColorByColorCode();
    }
}
