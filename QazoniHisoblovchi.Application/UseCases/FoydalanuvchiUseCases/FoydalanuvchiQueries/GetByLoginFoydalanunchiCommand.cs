using MediatR;
using QazoniHisoblovchi.Domain.Entities;

namespace QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiQueries
{
    public class GetByLoginFoydalanunchiCommand : IRequest<Foydalanuvchilar>
    {
        public string Login { get; set; }
    }
}
