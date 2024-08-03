using MediatR;
using Microsoft.EntityFrameworkCore;
using QazoniHisoblovchi.Application.Abstract;
using QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiCommands;
using QazoniHisoblovchi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiHandlers
{
    public class DeleteFoydalanuvchiCommandHandler : IRequestHandler<DeleteFoydalanuvchiCommand,bool>
    {
        private readonly IQazoHisoblovchiDbContext _qazoHisoblovchi;
        public DeleteFoydalanuvchiCommandHandler(IQazoHisoblovchiDbContext qazoHisoblovchi )        {
            _qazoHisoblovchi = qazoHisoblovchi;
        }
        public async Task<bool> Handle(DeleteFoydalanuvchiCommand request, CancellationToken cancellationToken)
        {
            Foydalanuvchilar foydalanuvchi = await _qazoHisoblovchi.foydalanuvchilar.FirstOrDefaultAsync(x => x.Login == request.Login);
            QazoNamozlar qazo = await _qazoHisoblovchi.qazoNamozlar.FirstOrDefaultAsync(x => x.FoydalanuvchiId == foydalanuvchi.id);
            if (foydalanuvchi != null)
            {
                try
                {
                    _qazoHisoblovchi.foydalanuvchilar.Remove(foydalanuvchi);
                    _qazoHisoblovchi.qazoNamozlar.Remove(qazo);
                    await _qazoHisoblovchi.SaveChangesAsync(cancellationToken);
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
