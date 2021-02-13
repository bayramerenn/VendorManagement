using Core.Dto.CivilDto;
using Core.Utilities.Result;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        public Task<IDataResult<List<ColorDescDto>>> GetColorByColorCode();
    }
}
