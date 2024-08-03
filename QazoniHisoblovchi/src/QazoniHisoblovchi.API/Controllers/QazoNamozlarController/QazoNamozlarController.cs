using Azure.Core;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QazoniHisoblovchi.API.DTO.FoydalanuvchiDto;
using QazoniHisoblovchi.API.DTO.QazoNamozDto;
using QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiCommands;
using QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiQueries;
using QazoniHisoblovchi.Application.UseCases.QazoNamozlariUseCases.QazoNamozlarCommands;
using QazoniHisoblovchi.Domain.Entities;

namespace QazoniHisoblovchi.API.Controllers.QazoNamozlarController
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QazoNamozlarController : ControllerBase
    {
        private readonly IMediator _mediator;
        public QazoNamozlarController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //1 yaratish
        [HttpPost]
        public async ValueTask<IActionResult> CreateQazoNamozlar(QazoNamozlarCreateCommand request)
        {
                       
            return Ok(await _mediator.Send(request));
        }
        //2 barchasini olish
        [HttpGet]
        public async ValueTask<IActionResult> GetAllQazoNamozlar()
        {
            IEnumerable<Foydalanuvchilar> result = await _mediator.Send(new GetAllFoydalanuvchiCommand());
            return Ok(result);
        }
        //3 bittasini olish
        [HttpGet]
        public async ValueTask<IActionResult> GetQazoNamozlarByIdAsync(string login)
        {
            GetByLoginFoydalanuvchiCommand command = new GetByLoginFoydalanuvchiCommand { Login = login };
            return Ok(await _mediator.Send(command));
        }

    }
}
