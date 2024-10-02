using Domain.Entities.Common;

namespace Domain.Entities;

public class Student : BaseEntity
{
    public Guid ObjectId { get; set; }
    public Group Group { get; set; }
}
