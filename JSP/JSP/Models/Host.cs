using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JSP.Models;
using System.ComponentModel.DataAnnotations;

namespace JSP.Models
{
    public class Host:User
    {
        [Required]
        [StringLength(255)]
        public string hostId { get; set; }
        public int contestCount { get; set; }
        public int postCount { get; set; }
        public HostType hostType { get; set; }
        public byte hostTypeId { get; set; }
    }
}