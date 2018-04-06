using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JSP.Models
{
    public class Contestant : User
    {
        public string ContestantId { get; set; }
        public int contestCount { get; set; }
        public int solveCount { get; set; }
        public int problemSets { get; set; }

    }
}