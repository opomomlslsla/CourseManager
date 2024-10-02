using Application.DTO;
using Application.Services.Common;
using Domain.Entities;
using Domain.Interfaces;
using System.Threading.Tasks;

namespace Application.Services;

public class GroupService(IRepository<Group> repository) : BaseService<Group, GroupDTO>(repository)
{
}
