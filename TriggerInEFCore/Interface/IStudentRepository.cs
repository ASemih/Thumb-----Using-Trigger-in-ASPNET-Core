using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriggerInEFCore.Model;

namespace TriggerInEFCore.Interface
{
    public interface IStudentRepository
    {
        Task<bool> SaveChangesAsync();
        void Add(Student student);
    }
}
