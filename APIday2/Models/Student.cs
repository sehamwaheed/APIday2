using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace APIday2.Models
{
    public class Student
    {
        public int Id { set; get; }

        [Required]
       
        public string Name { set; get; }
        [Range(18, 40)]
        public int Age { set; get; }

        [Required]
        public string Email { set; get; }
        [Required]
        public string Password { set; get; }
    

       

        [ForeignKey("Department")]
        public int? DeptId { get; set; }


        public virtual Department Department { set; get; }

        
    }
}