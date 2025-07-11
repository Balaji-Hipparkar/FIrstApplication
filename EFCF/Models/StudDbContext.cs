using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFCF.Models
{
    public class StudDbContext:DbContext
    {
        public StudDbContext() 
        {

        }
        public DbSet<StudInfo>studInfos { get; set; }   

    }
}