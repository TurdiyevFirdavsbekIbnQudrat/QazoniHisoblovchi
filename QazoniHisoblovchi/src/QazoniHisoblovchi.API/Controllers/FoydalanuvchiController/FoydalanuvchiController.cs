using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QazoniHisoblovchi.API.DTO.FoydalanuvchiDto;

namespace QazoniHisoblovchi.API.Controllers.FoydalanuvchiController
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoydalanuvchiController : ControllerBase
    {
        private readonly IMediator _mediator;
        public FoydalanuvchiController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async ValueTask<IActionResult> CreateFoydalanuvchi(FoydalanuvchiCreateDto foydalanuvchiCreateDto)
        {
            return Ok(await _mediator.Send(foydalanuvchiCreateDto));
        }
    }
}
