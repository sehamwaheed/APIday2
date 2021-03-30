using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIday2.Models
{
    public class Department
    {
        public int Id { set; get; }

        [Required]
        public string DeptName { set; get; }

        public virtual List<Student> Students { set; get; }

    }
}