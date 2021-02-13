using Business.Abstract;
using Business.Dtos;
using Core.Entities.Identity;
using Core.Utilities.IoC;
using Core.Utilities.Result;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Concrete
{
    public class UserService : IUserService
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        private IHttpContextAccessor _httpContextAccessor;
        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
        }

        public async Task<IDataResult<List<string>>> CreateAsync(UserDto userDto)
        {
            AppUser user = new AppUser
            {
                UserName = userDto.UserName,
                Email = userDto.Email,
                PhoneNumber = userDto.PhoneNumber
            };
           
           var result = await _userManager.CreateAsync(user,userDto.Password);
            if (result.Succeeded)
            {
                return new SuccessDataResult<List<string>> ("Kullanıcı oluşturuldu");
            }
            return new ErrorDataResult<List<string>> (GetErrorList(result.Errors));
        }

        private List<string> GetErrorList(IEnumerable<IdentityError> errors)
        {
            var data = errors.Select(s => s.Description).ToList();
            return data;
        }

        public IDataResult<List<AppUser>> GetUsers()
        {
            var result = _userManager.Users.ToList();
            return new SuccessDataResult<List<AppUser>>(result);

            
        }

        public async Task<IResult> Login(UserDto userDto)
        {
            var user = await _userManager.FindByEmailAsync(userDto.Email);
            if (user == null)
            {
                return new ErrorResult("Şifre ve kullanıcı adı hatalı");
            }
            var result = await _signInManager.PasswordSignInAsync(user, userDto.Password,true,false);
            if (result.Succeeded)
            {
               var name =  _httpContextAccessor.HttpContext.User.Identity.Name;
                return new SuccessResult("Giriş başarılı");
            }
            return new ErrorResult("Şifre ve kullanıcı adı hatalı");
        }

        public async Task<string> GetUserName()
        {
            var name = _httpContextAccessor.HttpContext.User;
            var user = await _userManager.GetUserAsync(name);

            return $"{user.FirstName} {user.LastName}";
        }
    }
}
