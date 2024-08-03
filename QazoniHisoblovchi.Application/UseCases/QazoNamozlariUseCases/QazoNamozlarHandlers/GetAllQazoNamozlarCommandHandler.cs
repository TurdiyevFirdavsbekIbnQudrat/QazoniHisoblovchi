using MediatR;
using Microsoft.EntityFrameworkCore;
using QazoniHisoblovchi.Application.Abstract;
using QazoniHisoblovchi.Application.UseCases.QazoNamozlariUseCases.QazoNamozlarQueries;
using QazoniHisoblovchi.Domain.Entities;

namespace QazoniHisoblovchi.Application.UseCases.QazoNamozlariUseCases.QazoNamozlarHandlers
{
    public class GetAllQazoNamozlarCommandHandler : IRequestHandler<QazoNamozlarGetAllCommand, IEnumerable<QazoNamozlar>>
    {
        private readonly IQazoHisoblovchiDbContext _qazoHisoblovchi;
        public GetAllQazoNamozlarCommandHandler(IQazoHisoblovchiDbContext qazoHisoblovchi)
        {
            _qazoHisoblovchi = qazoHisoblovchi;
        }

        public async Task<IEnumerable<QazoNamozlar>> Handle(QazoNamozlarGetAllCommand request, CancellationToken cancellationToken)
        {
            IEnumerable<QazoNamozlar> qazolar = await _qazoHisoblovchi.qazoNamozlar.ToListAsync();
            if(qazolar != null)
            {
                return qazolar;
            }
            return Enumerable.Empty<QazoNamozlar>();
        }
    }
}
