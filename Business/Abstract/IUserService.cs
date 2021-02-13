using Business.Dtos;
using Core.Entities.Identity;
using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<AppUser>> GetUsers();
        Task<IDataResult<List<string>>> CreateAsync(UserDto userDto);
        Task<IResult> Login(UserDto userDto);
        Task<string> GetUserName();
    }
}
