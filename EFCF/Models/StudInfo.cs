using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCF.Models
{
    public class StudInfo
    {
        [Key]
        public int StudNo { get; set; }
        public String StudName { get; set; }    
        public string Course { get; set; }
        public int Fee { get; set; }
    }
}