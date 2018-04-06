using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JSP.Models
{
    public class Contest
    {
        public int id { get; set; }
        public string name { get; set; }
        public string hostId { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public List<Problem> problems { get; set; }
    }

}