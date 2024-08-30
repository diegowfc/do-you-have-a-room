using AutoMapper;
using Domain.Entities;
using Application.DTOs.UserDTO;

namespace Application.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserCreateDTO, User>();
            CreateMap<User, UserReadDTO>();
            CreateMap<UserUpdateDTO, User>();
        }
    }
}
