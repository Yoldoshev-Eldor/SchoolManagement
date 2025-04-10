using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataAccess.Entities;

public class Class
{
    public int ClassID { get; set; }
    public string ClassName { get; set; }

    public ICollection<StudentClass> Students { get; set; }
    public ICollection<TeacherClass> Teachers { get; set; }
}

