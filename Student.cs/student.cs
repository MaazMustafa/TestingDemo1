using Ststem;
using System.Collections.Generic;

namespace name
{
    public class Students
    {
        public int StudentNo { get; set; }
        public string SName { get; set; }
<<<<<<< HEAD


        // changes by Mru . . .
        public int PRN { get; set; }
        public int Age { get; set; }

        public Students()
        {

        }
        public Students(int rollno,string name,int prn.int age)
        {
            this.StudentNo = rollno;
            this.SName = name;
            this.PRN = prn;
            this.Age = age;


        }
=======
        //added
        public int RollNo { get; set; }
>>>>>>> 97a73d099c31bf4a94f59a5a2eec3c426fc42ec6
    }
}