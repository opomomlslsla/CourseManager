using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories.Common;

namespace Infrastructure.Repositories;

public class StudentRepository(Context context) : BaseRepository<Student>(context)
{
}
