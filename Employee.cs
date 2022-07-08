using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORMFrameWork.Models
{
    [Table("emp10")]
    public class Employee
    {
       
        [Key]
        
        public int empno { get; set; }
        [Required]
        public string ename { get; set; }
        
        //public DateTime hdate { get; set; }
        [Required]
        public string job { get; set; }
        [Range(minimum:1,maximum:1000)]
        public int deptno { get; set; }

    }
}