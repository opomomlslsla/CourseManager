using Application.DTO;
using Application.Services.Common;
using Appliction.DTO;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using Infrastructure;
using Mapster;

namespace Application.Services;

public class CourseService(IRepository<Course> repository) : BaseService<Course, CourseDTO>(repository)
{

}
