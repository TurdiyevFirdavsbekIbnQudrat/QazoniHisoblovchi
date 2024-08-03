using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QazoniHisoblovchi.Application.UseCases.QazoNamozlariUseCases.QazoNamozlarCommands
{
    public class QazoNamozlarCreateCommand:IRequest<bool>
    {
        public string Bomdod { get; set; }
        public string Peshin { get; set; }
        public string PeshinSafar { get; set; }
        public string Asr { get; set; }
        public string AsrSafar { get; set; }
        public string Shom { get; set; }
        public string Xufton { get; set; }
        public string XuftonSafar { get; set; }
        public string Vitr { get; set; }
        public string Roza { get; set; }
        public string Login { get; set; }
    }
}
