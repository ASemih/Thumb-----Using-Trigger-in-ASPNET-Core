using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriggerInEFCore.Interface;
using TriggerInEFCore.Model;

namespace TriggerInEFCore.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private ApplicationDbContext _context { get; }

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Student student)
        {
            _context.Students.Add(student);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
