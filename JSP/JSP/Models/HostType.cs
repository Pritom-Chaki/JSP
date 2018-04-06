using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JSP.Models
{
    public class HostType
    {
        public byte id { get; set; }
        public short signUpFee { get; set; }
        public byte durationInYear { get; set; }
        public byte activityRate { get; set; }
    }
}