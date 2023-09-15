using MauiApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp4.Services
{
    internal class StudentService : IStudentService
    {
        public Task<bool> AddStudent()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteStudent(StudentModel studentModel)
        {
            throw new NotImplementedException();
        }

        public Task<List<StudentModel>> GetStudentList()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStudent(StudentModel studentModel)
        {
            throw new NotImplementedException();
        }
    }
}
