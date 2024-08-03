using MediatR;
using Microsoft.EntityFrameworkCore;
using QazoniHisoblovchi.Application.Abstract;
using QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiQueries;
using QazoniHisoblovchi.Domain.Entities;

namespace QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiHandlers
{
    public class GetByLoginFoydalanuvchiCommandHandler : IRequestHandler<GetByLoginFoydalanuvchiCommand, Foydalanuvchilar>
    {
        private readonly IQazoHisoblovchiDbContext _qazoHisoblovchi;

        public GetByLoginFoydalanuvchiCommandHandler(IQazoHisoblovchiDbContext qazoHisoblovchi)
        {
            _qazoHisoblovchi = qazoHisoblovchi;
        }

        public async Task<Foydalanuvchilar> Handle(GetByLoginFoydalanuvchiCommand request, CancellationToken cancellationToken)
        {
            Foydalanuvchilar result = await _qazoHisoblovchi.foydalanuvchilar.FirstOrDefaultAsync(x => x.Login == request.Login);
            if (result != null)
            {
                return result;
            }
            return new Foydalanuvchilar();
        }
    }
}
