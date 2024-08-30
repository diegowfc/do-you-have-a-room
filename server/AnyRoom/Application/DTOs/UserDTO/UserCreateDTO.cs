namespace Application.DTOs.UserDTO
{
    public class UserCreateDTO
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Document { get; set; }

        public string Gender { get; set; }  
    }
}
