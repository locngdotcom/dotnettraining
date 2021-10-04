using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetTraining.Entity;

namespace DotnetTraining.Services.Student
{
    public class StudentLogicService : IStudentLogicService
    {
        public List<DotnetTraining.Entity.Student> GetStudent()
        {
            var student1 = new DotnetTraining.Entity.Student { Id = Guid.NewGuid().ToString(), Class = "Rookies", Name = "Nguyen Van A" };
            var student2 = new DotnetTraining.Entity.Student { Id = Guid.NewGuid().ToString(), Class = "Rookies", Name = "Nguyen Van B" };
            var student3 = new DotnetTraining.Entity.Student { Id = Guid.NewGuid().ToString(), Class = "Rookies", Name = "Nguyen Van C" };
            var listOfStudents = new List<DotnetTraining.Entity.Student>();
            listOfStudents.Add(student1);
            listOfStudents.Add(student2);
            listOfStudents.Add(student3);

            return listOfStudents;
        }
    }
}
