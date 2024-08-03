using MediatR;
using Microsoft.EntityFrameworkCore;
using QazoniHisoblovchi.Application.Abstract;
using QazoniHisoblovchi.Application.UseCases.QazoNamozlariUseCases.QazoNamozlarCommands;
using QazoniHisoblovchi.Domain.Entities;

namespace QazoniHisoblovchi.Application.UseCases.QazoNamozlariUseCases.QazoNamozlarHandlers
{
    public class QazoNamozlarCreateCommandHandler : IRequestHandler<QazoNamozlarCreateCommand, bool>
    {

        private readonly IQazoHisoblovchiDbContext _qazoHisoblovchi;
         public QazoNamozlarCreateCommandHandler(IQazoHisoblovchiDbContext qazoHisoblovchi)
        {
            _qazoHisoblovchi = qazoHisoblovchi;
        }
        public async Task<bool> Handle(QazoNamozlarCreateCommand request, CancellationToken cancellationToken)
        {
            Foydalanuvchilar foydalanuvchi = await _qazoHisoblovchi.foydalanuvchilar.FirstOrDefaultAsync(x => x.Login == request.Login);
            if (foydalanuvchi != null)
            {
                QazoNamozlar qazolar = new QazoNamozlar()
                {
                    Roza = request.Roza+"|0",
                    Shom = request.Shom + "|0",
                    AsrSafar = request.AsrSafar + "|0",
                    PeshinSafar = request.PeshinSafar + "|0",
                    XuftonSafar = request.XuftonSafar + "|0",
                    Asr = request.Asr + "|0",
                    Bomdod = request.Bomdod + "|0",
                    FoydalanuvchiId = foydalanuvchi.id,
                    Peshin = request.Peshin + "|0",
                    Vitr = request.Vitr + "|0" ,
                    Xufton = request.Xufton + "|0" ,
                };
                
                try
                {
                    await _qazoHisoblovchi.qazoNamozlar.AddAsync(qazolar);
                    _qazoHisoblovchi.SaveChangesAsync(cancellationToken);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}
