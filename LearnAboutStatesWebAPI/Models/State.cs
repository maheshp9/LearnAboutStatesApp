using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnAboutStatesWebAPI.Models
{
    public class State
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string MapUri { get; set; }

        public string Description { get; set; }
    }
}