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
//hello all
//how are you
//this is comment
namespace ORMFrameWork.Models
{
    //this is employee class
    //extra comments again added by omkar jadhav
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
        

        public string city { get; set; }

        

    }
}
//comment added by omkar jadhav
//new comments added 
<<<<<<< HEAD
//comment added by Ravi Mohite
=======
//Again comment by omkar
<<<<<<< HEAD
>>>>>>> ce95969bd2122bce86b9c9daba9fe03f479aee86
=======
// This is Omkar Ganjave Adding comment

>>>>>>> ec01690b4b40b31bff8150b27d7f32624ded855b
