using System;
using System.ComponentModel.DataAnnotations;
using API.Entities;
using API.Interfaces;
using API.DTOs;
namespace API.Extensions
{
    public static class AppUserExtensions
    {
        public static UserDto ToDto(this AppUser user, ITokenService tokenService)
        {
            return new UserDto
            {
                Id = user.Id,
                DisplayName = user.DisplayName,
                Email = user.Email,
                Token = tokenService.CreateToken(user)
            };
            
        }
    }
}