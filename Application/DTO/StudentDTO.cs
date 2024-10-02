using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO;

public class StudentDTO : BaseDTO
{
    public Guid ObjectId { get; set; }
    public Guid GroupId { get; set; }
}
