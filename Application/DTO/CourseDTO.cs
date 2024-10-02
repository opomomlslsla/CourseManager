using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO;

public class CourseDTO : BaseDTO
{
    public List<Guid> DisciplineIds { get; set;}
    public List<Guid> GroupsIds { get; set;}
    public Guid CourseManagerId { get; set; }
    public int CourseStatus {  get; set; }

}
