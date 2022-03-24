using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUpProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Phone { get; set; }   
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Gender { get; set; }

    }

    public class Student_Db
    {
        public int Db_Id { get; set; }
        public string Db_Name { get; set; }
        public string Db_Origin { get; set; }
        public string Db_Pass { get; set; }
        public string Db_Gender { get; set; }
        public string Db_Email { get; set; }
        public string Db_Birthday { get; set; }
        public string Db_Phone { get; set; }
    }
}
