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
    public class FoydalanuvchiUpdateCommandHandler : IRequestHandler<FoydalanuvchiUpdateCommand, bool>
    {
        private readonly IQazoHisoblovchiDbContext _qazoHisoblovchi;
        public FoydalanuvchiUpdateCommandHandler(IQazoHisoblovchiDbContext qazoHisoblovchi)
        {
            _qazoHisoblovchi = qazoHisoblovchi;
        }
        public async Task<bool> Handle(FoydalanuvchiUpdateCommand request, CancellationToken cancellationToken)
        {
            Foydalanuvchilar foydalanuvchi = await _qazoHisoblovchi.foydalanuvchilar.FirstOrDefaultAsync(x => x.Login == request.Login);

            foydalanuvchi.Name = request.Name;
            foydalanuvchi.Martaba = request.Martaba;
            foydalanuvchi.Password = request.Password;
            if (foydalanuvchi != null)
            {
                try
                {
                    _qazoHisoblovchi.foydalanuvchilar.Update(foydalanuvchi);
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
