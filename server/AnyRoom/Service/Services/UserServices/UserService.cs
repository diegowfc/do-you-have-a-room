using Domain.DTOs.UserDTO;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Service.Services.UserServices;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IPasswordHasher _passwordHasher;

        public UserService(DataContext context, IMapper mapper, IPasswordHasher passwordHasher)
        {
            _context = context;
            _mapper = mapper;
            _passwordHasher = passwordHasher;
        }

        public async Task<UserReadDTO> RegisterUserAsync(UserCreateDTO userCreateDTO)
        {
            var hashedPassword = _passwordHasher.Hash(userCreateDTO.Password);
            userCreateDTO.Password = hashedPassword;

            var user = _mapper.Map<User>(userCreateDTO);

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            var userReadDTO = _mapper.Map<UserReadDTO>(user);

            return userReadDTO;
        }

    }
}
