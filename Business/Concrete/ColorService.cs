using Business.Abstract;
using Business.Contants;
using Core.Dto.CivilDto;
using Core.Utilities.Result;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorService : IColorService
    {
        private ICdColorDal _cdColor;

        public ColorService(ICdColorDal cdColor)
        {
            _cdColor = cdColor;

        }

        public async Task<IDataResult<List<ColorDescDto>>> GetColorByColorCode()
        {

            try
            {
                var result = await _cdColor.GetColorByColorCode();

                return new SuccessDataResult<List<ColorDescDto>>(result);
            }
            catch (Exception e)
            {

                return new ErrorDataResult<List<ColorDescDto>>(e.ToString());
            }
        }
    }
}
