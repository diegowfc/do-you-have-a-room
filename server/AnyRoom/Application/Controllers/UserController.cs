using Domain.DTOs.UserDTO;
using AutoMapper;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Service.Services.UserServices;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(DataContext context, IMapper mapper, IUserService userService)
        {
            _context = context;
            _mapper = mapper;
            _userService = userService;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserCreateDTO userCreateDTO)
        {
            var userDTO = await _userService.RegisterUserAsync(userCreateDTO);

            return CreatedAtAction(nameof(RegisterUser), new { id = userDTO.ID }, userDTO);
        }
    }
}
