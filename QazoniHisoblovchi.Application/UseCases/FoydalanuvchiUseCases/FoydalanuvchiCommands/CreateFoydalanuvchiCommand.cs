using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiCommands
{
    public class CreateFoydalanuvchiCommand
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password {  get; set; }
        public int Martaba {  get; set; }
    }
}
