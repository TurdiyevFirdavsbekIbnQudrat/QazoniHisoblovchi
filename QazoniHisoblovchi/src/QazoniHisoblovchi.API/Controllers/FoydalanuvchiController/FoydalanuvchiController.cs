using MediatR;
using Microsoft.AspNetCore.Mvc;
using QazoniHisoblovchi.API.DTO.FoydalanuvchiDto;
using QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiCommands;
using QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiQueries;
using QazoniHisoblovchi.Domain.Entities;

namespace QazoniHisoblovchi.API.Controllers.FoydalanuvchiController
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FoydalanuvchiController : ControllerBase
    {
        private readonly IMediator _mediator;
        public FoydalanuvchiController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //1 yaratish
        [HttpPost]
        public async ValueTask<IActionResult> CreateFoydalanuvchi(FoydalanuvchiCreateDto foydalanuvchiCreateDto)
        {
            CreateFoydalanuvchiCommand foydalanuvchi = new CreateFoydalanuvchiCommand()
            {
                Login = foydalanuvchiCreateDto.Login,
                Martaba = foydalanuvchiCreateDto.Martaba,
                Name = foydalanuvchiCreateDto.Name,
                Password = foydalanuvchiCreateDto.Password
            };
            return Ok(await _mediator.Send(foydalanuvchi));
        }
        //2 barchasini olish
        [HttpGet]
        public async ValueTask<IActionResult> GetAllFoydalanuvchi()
        {
            IEnumerable<Foydalanuvchilar> result = await _mediator.Send(new GetAllFoydalanuvchiCommand());
            return Ok(result);
        }
        //3 bittasini olish
        [HttpGet]
        public async ValueTask<IActionResult> GetFoydalanuvchiByLoginAsync(string login)
        {
            GetByLoginFoydalanuvchiCommand command = new GetByLoginFoydalanuvchiCommand { Login = login };
            return Ok(await _mediator.Send(command));
        }
        //4 yangilash
        [HttpPut]
        public async ValueTask<IActionResult> UpdateFoydalanuvchiByLoginAsync(FoydalanuvchiUpdateCommand foydalanuvchi)
        {
            return Ok(await _mediator.Send(foydalanuvchi));
        }
        //5 o'chirish
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteFoydalanuvchiAsync(string login)
        {
            DeleteFoydalanuvchiCommand del = new DeleteFoydalanuvchiCommand () { Login = login};
            return Ok(await _mediator.Send(del));
        }
    }
}
