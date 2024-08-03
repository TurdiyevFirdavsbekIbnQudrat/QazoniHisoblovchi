using MediatR;
using QazoniHisoblovchi.Application.Abstract;
using QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiHandlers
{
    public class CreateFoydalanuvchiCommandHandler : IRequestHandler<CreateFoydalanuvchiCommand, bool>
    {
        private readonly IQazoHisoblovchiDbContext _qazoHisoblovchi;
        
        public CreateFoydalanuvchiCommandHandler(IQazoHisoblovchiDbContext qazoHisoblovchi)
        {
            _qazoHisoblovchi = qazoHisoblovchi;
        }

        public Task<bool> Handle(CreateFoydalanuvchiCommand request, CancellationToken cancellationToken)
        {

        }
    }
}
