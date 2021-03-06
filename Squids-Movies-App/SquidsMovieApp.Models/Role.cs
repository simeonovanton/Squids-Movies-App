﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquidsMovieApp.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        //public int ParticipantId { get; set; }
        public virtual Participant Participant { get; set; }
        //public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
