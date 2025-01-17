﻿using MediatR;
using QazoniHisoblovchi.Domain.Enums;

namespace QazoniHisoblovchi.Application.UseCases.FoydalanuvchiUseCases.FoydalanuvchiCommands
{
    public class CreateFoydalanuvchiCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public FoydalanuvchiEnum Martaba { get; set; }
    }
}
