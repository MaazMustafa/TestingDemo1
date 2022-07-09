using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
class person()
{
    private int date;
}
//this is comment
namespace ORMFrameWork.Models
{
    //this is employee class
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
        
        public double sal{get;set;}
        public string EmailId { get; set; }
        

        public string city{get;set;}

        

    }
}
//comment added by omkar jadhav
//new comments added 
//Again comment by omkar
// This is Omkar Ganjave Adding comment

