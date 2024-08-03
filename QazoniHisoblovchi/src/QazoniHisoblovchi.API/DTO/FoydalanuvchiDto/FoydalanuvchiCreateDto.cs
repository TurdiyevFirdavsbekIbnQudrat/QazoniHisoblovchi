using QazoniHisoblovchi.Domain.Enums;

namespace QazoniHisoblovchi.API.DTO.FoydalanuvchiDto
{
    public class FoydalanuvchiCreateDto
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public FoydalanuvchiEnum Martaba { get; set; }
    }
}
