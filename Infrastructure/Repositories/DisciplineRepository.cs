using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class DisciplineRepository(Context context) : BaseRepository<Disciplline>(context)
{
    public override async Task<Disciplline?> GetEntityByIdAsync(Guid id)
    {
        return await context.Discipllines
            .Include(x=> x.Tutors)
            .FirstOrDefaultAsync(x => x.Id == id);
    }
}
