namespace Application.DTOs.UserDTO
{
    public class UserReadDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Status { get; set; }

        public string Roles { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
