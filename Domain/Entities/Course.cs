using Domain.Entities.Common;
using Domain.Enums;

namespace Domain.Entities;

public class Course : BaseEntity
{
    public string Description { get; set; }
    public Guid CourseManagerId { get; set; }
    public List<Disciplline> Discipllines { get; set; } = new List<Disciplline>();
    public List<Group> Groups { get; set; } = new List<Group> { };
    public CourseStatus Status { get; set; }
}
