using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories.Common;

namespace Infrastructure.Repositories;

public class TutorRepository(Context context) : BaseRepository<Tutor>(context)
{
}
