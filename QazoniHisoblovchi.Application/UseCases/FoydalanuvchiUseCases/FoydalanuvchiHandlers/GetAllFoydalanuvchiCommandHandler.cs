using MediatR;
using Microsoft.EntityFrameworkCore;
using QazoniHisoblovchi.Application.Abstract;
using QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiQueries;
using QazoniHisoblovchi.Domain.Entities;

namespace QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiHandlers
{
    public class GetAllFoydalanuvchiCommandHandler : IRequestHandler<GetAllFoydalanuvchiCommand, IEnumerable<Foydalanuvchilar>>
    {
        private readonly IQazoHisoblovchiDbContext _qazoHisoblovchi;
        public GetAllFoydalanuvchiCommandHandler(IQazoHisoblovchiDbContext qazoHisoblovchi)
        {
            _qazoHisoblovchi = qazoHisoblovchi;
        }
        public async Task<IEnumerable<Foydalanuvchilar>> Handle(GetAllFoydalanuvchiCommand request, CancellationToken cancellationToken)
        {
            IEnumerable<Foydalanuvchilar> foydalanuvchilar = await _qazoHisoblovchi.foydalanuvchilar.ToListAsync();
            if(foydalanuvchilar != null)
            {
                return foydalanuvchilar;
            }
            else
            {
                return Enumerable.Empty<Foydalanuvchilar>();
            }
        }
    }
}
