using System;
using System.Collections.Generic;
using System.Text;

namespace APITest.Model
{
    public class PostModel
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int totalprice { get; set; }
        public bool depositpaid { get; set; }
        public string checkin { get; set; }
        public string checkout { get; set; }
        public string additionalneeds { get; set; }
    }
}
