using MediatR;
using QazoniHisoblovchi.Domain.Entities;

namespace QazoniHisoblovchi.Application.UseCases.QazoNamozlariUseCases.QazoNamozlarQueries
{
    public class QazoNamozlarGetAllCommand : IRequest<IEnumerable<QazoNamozlar>>
    {
    }
}
