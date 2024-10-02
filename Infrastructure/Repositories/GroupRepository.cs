using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GroupRepository(Context context) : BaseRepository<Group>(context)
{
    public override Task<Group?> GetEntityByIdAsync(Guid id)
    {
        return context.Groups
            .Include(x=> x.Students)
            .FirstOrDefaultAsync(x => x.Id == id);
    }
}
