﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mismanagement.Api.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        public string Name { get; set; }

        public int Duration { get; set; }

        public Status Status { get; set; }

        public int StatusId { get; set; }

        public int EmployeeId { get; set; }

        public int ProjectId { get; set; }
    }
}
