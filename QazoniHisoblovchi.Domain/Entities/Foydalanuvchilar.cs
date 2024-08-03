using QazoniHisoblovchi.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace QazoniHisoblovchi.Domain.Entities
{
    public class Foydalanuvchilar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public FoydalanuvchiEnum Martaba { get; set; }
        //public int QazoNamozId { get; set; }
        //public QazoNamozlar QazoNamozlari { get; set; }
    }
}
