using MediatR;
using QazoniHisoblovchi.Application.Abstract;
using QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiCommands;
using QazoniHisoblovchi.Domain.Entities;

namespace QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiHandlers
{
    public class CreateFoydalanuvchiCommandHandler : IRequestHandler<CreateFoydalanuvchiCommand, bool>
    {
        private readonly IQazoHisoblovchiDbContext _qazoHisoblovchi;

        public CreateFoydalanuvchiCommandHandler(IQazoHisoblovchiDbContext qazoHisoblovchi)
        {
            _qazoHisoblovchi = qazoHisoblovchi;
        }

        public async Task<bool> Handle(CreateFoydalanuvchiCommand request, CancellationToken cancellationToken)
        {
            Foydalanuvchilar foydalanuvchi = new Foydalanuvchilar()
            {
                Login = request.Login,
                Martaba = request.Martaba,
                Name = request.Name,
                Password = request.Password
            };
          
                try
                {
                    await _qazoHisoblovchi.foydalanuvchilar.AddAsync(foydalanuvchi);
                     _qazoHisoblovchi.SaveChangesAsync(cancellationToken);
                    return true;
                }
                catch
                {
                    return false;
                }
            
            
        }
    }
}
