using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTraining.Services.Student
{
    public interface IStudentLogicService
    {
        List<DotnetTraining.Entity.Student> GetStudent();
    }
}
