using MauiApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp4.Services
{
    public interface IStudentService
    {
        Task<List<StudentModel>> GetStudentList();

        Task<bool> AddStudent();

        Task<bool> DeleteStudent(StudentModel studentModel);

        Task<bool> UpdateStudent(StudentModel studentModel);
    }
}
