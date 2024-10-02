using Domain.Entities.Common;

namespace Domain.Entities;

public class Disciplline : BaseEntity
{
    public Guid ObjectId { get; set; }
    public List<Tutor> Tutors { get; set; } = new List<Tutor>();
}
