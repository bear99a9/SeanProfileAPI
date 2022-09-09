﻿
using SeanProfile.Api.Model;

namespace SeanProfile.Api.DataLayer
{
    public interface IUserRepository
    {
        Task<bool> UserExists(string email);
        Task InsertNewUser(UserModel user);
        Task<UserModel> GetUserByEmail<T>(T user);
        Task<UserModel> GetUserById<T>(T user);
        Task UpdateUserPassword(UserModel user);
    }
}