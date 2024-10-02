using Application.Services.Common;
using Appliction.DTO;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using Infrastructure;
using Mapster;

namespace Application.Services;

public sealed class DisciplineService(IRepository<Disciplline> repository) : BaseService<Disciplline, DisciplineDTO>(repository)
{
 
}