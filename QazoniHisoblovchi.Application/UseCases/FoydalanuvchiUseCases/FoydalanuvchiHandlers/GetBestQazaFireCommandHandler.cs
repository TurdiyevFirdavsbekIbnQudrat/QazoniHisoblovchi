using MediatR;
using Microsoft.EntityFrameworkCore;
using QazoniHisoblovchi.Application.Abstract;
using QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiQueries;
using QazoniHisoblovchi.Domain.Entities;

namespace QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiHandlers
{
    public class GetBestQazaFireCommandHandler : IRequestHandler<GetBestQazaFireCommand, Foydalanuvchilar>
    {
        private readonly IQazoHisoblovchiDbContext _qazoHisoblovchi;
        public GetBestQazaFireCommandHandler(IQazoHisoblovchiDbContext qazoHisoblovchi)
        {
            _qazoHisoblovchi = qazoHisoblovchi;
        }

        public async Task<Foydalanuvchilar> Handle(GetBestQazaFireCommand request, CancellationToken cancellationToken)
        {

            //Foydalanuvchilar result = await _qazoHisoblovchi.foydalanuvchilar.OrderBy(x=
            //QazoNamozlar qazochilar = await _qazoHisoblovchi.qazoNamozlar.FirstOrDefaultAsync(x => x.FoydalanuvchiId == result.id);
            return new Foydalanuvchilar();
        }
    }
}
