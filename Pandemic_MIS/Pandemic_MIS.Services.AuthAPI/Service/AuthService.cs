using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Pandemic_MIS.Services.AuthAPI.Data;
using Pandemic_MIS.Services.AuthAPI.Models;
using Pandemic_MIS.Services.AuthAPI.Models.Dto;
using Pandemic_MIS.Services.AuthAPI.Service.IService;
using System.Net;
using System.Numerics;
using System.Reflection;

namespace Pandemic_MIS.Services.AuthAPI.Service
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthService(AppDbContext db, IJwtTokenGenerator jwtTokenGenerator,
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _jwtTokenGenerator = jwtTokenGenerator;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<bool> AssignRole(string userName, string roleName)
        {
            var user = _db.ApplicationUsers.FirstOrDefault(u => u.UserName == userName);

            if (user != null) 
            {
                if (!_roleManager.RoleExistsAsync(roleName).GetAwaiter().GetResult()) 
                {
                    // Create role if it does not exist
                    _roleManager.CreateAsync(new IdentityRole(roleName)).GetAwaiter().GetResult();
                }
                await _userManager.AddToRoleAsync(user, roleName);
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllUsers() 
        {
            IEnumerable<ApplicationUser> objList = _db.ApplicationUsers.OrderByDescending(x => x.UpdatedDate).ToList();
            return objList;
        }

        public async Task<UserDto> GetByUsername(string username)
        {
            var user = _db.ApplicationUsers.FirstOrDefault(u => u.UserName.ToLower().Equals(username.ToLower()));
            var userRole = await _userManager.GetRolesAsync(user);

            UserDto userDto = new()
            {
                Id = user.Id,
                UserName = user.UserName,
                CallingName = user.CallingName,
                Gender = user.Gender,
                Salutation = user.Salutation,
                FullName = user.FullName,
                NICNumber = user.NICNumber,
                Address = user.Address,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Designation = user.Designation,
                IsActive = user.IsActive,
                LastLoginDate = user.LastLoginDate,
                Role = userRole[0],
            };

            return userDto;
        }

        public async Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            var user = _db.ApplicationUsers.FirstOrDefault(u => u.UserName.ToLower() == loginRequestDto.UserName.ToLower() && u.IsActive == true);
            bool isValid = await _userManager.CheckPasswordAsync(user, loginRequestDto.Password);
            var userRole = await _userManager.GetRolesAsync(user);

            if (user == null || isValid == false || userRole[0] == "APP_USER") 
            {
                return new LoginResponseDto() { User = null, Token = "" };
            }

            // If user was found, generate JWT token
            var token = _jwtTokenGenerator.GenerateToken(user);

            UserDto userDto = new()
            {
                Id = user.Id,
                UserName = user.UserName,
                CallingName = user.CallingName,
                Gender = user.Gender,
                Salutation = user.Salutation,
                FullName = user.FullName,
                NICNumber = user.NICNumber,
                Address = user.Address,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Designation = user.Designation,
                IsActive = user.IsActive,
                LastLoginDate = user.LastLoginDate,
                Role = userRole[0],
            };

            LoginResponseDto loginResponseDto = new LoginResponseDto()
            {
                User = userDto,
                Token = token
            };

            return loginResponseDto;
        }

        public async Task<LoginResponseDto> LoginPublic(LoginRequestDto loginRequestDto)
        {
            var user = _db.ApplicationUsers.FirstOrDefault(u => u.UserName.ToLower() == loginRequestDto.UserName.ToLower() && u.IsActive == true);
            bool isValid = await _userManager.CheckPasswordAsync(user, loginRequestDto.Password);
            var userRole = await _userManager.GetRolesAsync(user);

            if (user == null || isValid == false || userRole[0] != "APP_USER")
            {
                return new LoginResponseDto() { User = null, Token = "" };
            }

            // If user was found, generate JWT token
            var token = _jwtTokenGenerator.GenerateToken(user);

            UserDto userDto = new()
            {
                Id = user.Id,
                UserName = user.UserName,
                CallingName = user.CallingName,
                Gender = user.Gender,
                Salutation = user.Salutation,
                FullName = user.FullName,
                NICNumber = user.NICNumber,
                Address = user.Address,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Designation = user.Designation,
                IsActive = user.IsActive,
                LastLoginDate = user.LastLoginDate,
                Role = userRole[0],
            };

            LoginResponseDto loginResponseDto = new LoginResponseDto()
            {
                User = userDto,
                Token = token
            };

            return loginResponseDto;
        }

        public async Task<string> Register(RegistrationRequestDto registrationRequestDto)
        {
            ApplicationUser user = new()
            {
                UserName = registrationRequestDto.UserName,
                CallingName = registrationRequestDto.CallingName,
                Gender = registrationRequestDto.Gender,
                Salutation = registrationRequestDto.Salutation,
                FullName = registrationRequestDto.FullName,
                NICNumber = registrationRequestDto.NICNumber,
                Address = registrationRequestDto.Address,
                Email = registrationRequestDto.Email,
                NormalizedEmail = registrationRequestDto.Email.ToUpper(),
                PhoneNumber = registrationRequestDto.PhoneNumber,
                Designation = registrationRequestDto.Designation,
                IsActive = registrationRequestDto.IsActive,
                CreatedDate = registrationRequestDto.CreatedDate,
                UpdatedDate = registrationRequestDto.UpdatedDate,
                CreatedBy = registrationRequestDto.CreatedBy,
            };

            try 
            { 
                var result = await _userManager.CreateAsync(user, registrationRequestDto.Password);

                if (result.Succeeded)
                {
                    var isSuccess = await AssignRole(user.UserName, registrationRequestDto.Role);

                    if (isSuccess)
                    {
                        var userToReturn = _db.ApplicationUsers.First(u => u.UserName == registrationRequestDto.UserName);

                        UserDto userDto = new()
                        {
                            Id = userToReturn.Id,
                            UserName = userToReturn.UserName,
                            CallingName = userToReturn.CallingName,
                            Gender = userToReturn.Gender,
                            Salutation = userToReturn.Salutation,
                            FullName = userToReturn.FullName,
                            NICNumber = userToReturn.NICNumber,
                            Address = userToReturn.Address,
                            Email = userToReturn.Email,
                            PhoneNumber = userToReturn.PhoneNumber,
                            Designation = userToReturn.Designation,
                            IsActive = userToReturn.IsActive,
                            LastLoginDate = userToReturn.LastLoginDate,
                        };

                        return "";
                    }
                }
                else
                {
                    return result.Errors.FirstOrDefault().Description;
                }
            }
            catch(Exception ex) 
            {
            }

            return "Error Encountered";
        }

        public async Task<string> UpdateUser(string userId, UpdateUserRequestDto updateUserRequestDto)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return "Error Encountered";
            }

            user.Salutation = updateUserRequestDto.Salutation;
            user.FullName = updateUserRequestDto.FullName;
            user.CallingName = updateUserRequestDto.CallingName;
            user.Gender = updateUserRequestDto.Gender;
            user.NICNumber = updateUserRequestDto.NICNumber;
            user.Address = updateUserRequestDto.Address;
            user.PhoneNumber = updateUserRequestDto.PhoneNumber;
            user.Email = updateUserRequestDto.Email;
            user.NormalizedEmail = updateUserRequestDto.Email.ToUpper();
            user.Designation = updateUserRequestDto.Designation;
            user.IsActive = updateUserRequestDto.IsActive;
            user.UpdatedDate = updateUserRequestDto.UpdatedDate;

            try
            {
                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    var userToReturn = _db.ApplicationUsers.First(u => u.UserName == user.UserName);

                    UserDto userDto = new()
                    {
                        Id = userToReturn.Id,
                        UserName = userToReturn.UserName,
                        CallingName = userToReturn.CallingName,
                        Gender = userToReturn.Gender,
                        Salutation = userToReturn.Salutation,
                        FullName = userToReturn.FullName,
                        NICNumber = userToReturn.NICNumber,
                        Address = userToReturn.Address,
                        Email = userToReturn.Email,
                        PhoneNumber = userToReturn.PhoneNumber,
                        Designation = userToReturn.Designation,
                        IsActive = userToReturn.IsActive,
                        LastLoginDate = userToReturn.LastLoginDate,
                    };

                    return "";
                }
                else
                {
                    return result.Errors.FirstOrDefault().Description;
                }
            }
            catch (Exception ex)
            {
            }

            return "Error Encountered";

        }
    }
}
