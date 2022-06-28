﻿using Microsoft.AspNetCore.Identity;
using ShoopingNo9.Data.Entities;
using ShoopingNo9.Models;

namespace ShoopingNo9.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserAsync(string email);
        Task<IdentityResult> AddUserAsync(User user, string password);
        Task<User> AddUserAsync(AddUserViewModel model);
        Task CheckRoleAsync(string roleName);
        Task AddUserToRoleAsync(User user, string roleName);
        Task<bool> IsUserInRoleAsync(User user, string roleName);
        //Login 
        Task<SignInResult> LoginAsync(LoginViewModel model);
        Task LogoutAsync();
        //CangePassword
        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);
        Task<IdentityResult> UpdateUserAsync(User user);
        Task<User> GetUserAsync(Guid userId);

    }
}
