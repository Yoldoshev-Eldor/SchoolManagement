using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataAccess.Entities;

public class Student
{
    public int StudentID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    public ICollection<TeacherStudent> Teachers { get; set; }
    public ICollection<StudentClass> Classes { get; set; }
}

