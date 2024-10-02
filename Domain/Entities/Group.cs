using Domain.Entities.Common;
namespace Domain.Entities;

public class Group : BaseEntity
{
    public Guid ObjectId { get; set; }
    public string Number { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();
}
