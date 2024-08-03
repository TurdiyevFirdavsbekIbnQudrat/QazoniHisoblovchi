using MediatR;

namespace QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiCommands
{
    public class DeleteFoydalanuvchiCommand:IRequest<bool>
    {
        public string Login { get; set; }
    }
}
