using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class CourseRepository(Context context) : BaseRepository<Course>(context)
{
    public override Task<Course?> GetEntityByIdAsync(Guid id)
    {
        return context.Courses
            .Include(x => x.Groups)
            .Include(x => x.Discipllines)
            .FirstOrDefaultAsync(c => c.Id == id);
    }
}
