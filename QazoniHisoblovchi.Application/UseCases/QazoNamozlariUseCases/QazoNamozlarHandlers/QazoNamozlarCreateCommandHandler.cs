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
            QazoNamozlar qazolar = new QazoNamozlar()
            {
                Roza = request.Roza,
                Shom = request.Shom,
                AsrSafar = request.AsrSafar,
                PeshinSafar = request.PeshinSafar,
                XuftonSafar = request.XuftonSafar,
                Asr = request.Asr,
                Bomdod = request.Bomdod,
                FoydalanuvchiId = foydalanuvchi.id,
                Peshin = request.Peshin,
                Vitr = request.Vitr,
                Xufton = request.Xufton,
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
    }
}
