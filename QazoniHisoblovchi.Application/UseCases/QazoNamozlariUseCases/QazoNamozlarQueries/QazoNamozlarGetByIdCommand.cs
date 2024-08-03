using MediatR;
using QazoniHisoblovchi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QazoniHisoblovchi.Application.UseCases.QazoNamozlariUseCases.QazoNamozlarQueries
{
    public class QazoNamozlarGetByIdCommand:IRequest<QazoNamozlar>
    {
        public int id {  get; set; }
    }
}
