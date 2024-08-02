using QazoniHisoblovchi.Domain.Enums;

namespace QazoniHisoblovchi.Domain.Entities
{
    public class Foydalanuvchilar
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public FoydalanuvchiEnum Maqom {  get; set; }

    }
}
