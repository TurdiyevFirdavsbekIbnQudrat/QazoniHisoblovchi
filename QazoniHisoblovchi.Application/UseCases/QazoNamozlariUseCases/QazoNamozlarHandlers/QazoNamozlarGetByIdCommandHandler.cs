using MediatR;
using Microsoft.EntityFrameworkCore;
using QazoniHisoblovchi.Application.Abstract;
using QazoniHisoblovchi.Application.UseCases.QazoNamozlariUseCases.QazoNamozlarQueries;
using QazoniHisoblovchi.Domain.Entities;

namespace QazoniHisoblovchi.Application.UseCases.QazoNamozlariUseCases.QazoNamozlarHandlers
{
    public class QazoNamozlarGetByIdCommandHandler : IRequestHandler<QazoNamozlarGetByIdCommand, QazoNamozlar>
    {
        private readonly IQazoHisoblovchiDbContext _qazoHisoblovchi;
        public QazoNamozlarGetByIdCommandHandler(IQazoHisoblovchiDbContext qazoHisoblovchi)
        {
            _qazoHisoblovchi = qazoHisoblovchi;
        }

        public async Task<QazoNamozlar> Handle(QazoNamozlarGetByIdCommand request, CancellationToken cancellationToken)
        {
            QazoNamozlar qazo = await _qazoHisoblovchi.qazoNamozlar.FirstOrDefaultAsync(x => x.id == request.id);
            if (qazo != null)
            {
                return qazo;
            }
            return new QazoNamozlar();
        }
    }
}
