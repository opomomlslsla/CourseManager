﻿using Application.DTO;
using Application.Services.Common;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services;

public class TutorService(IRepository<Tutor> repository) : BaseService<Tutor, TutorDTO>(repository)
{
}
