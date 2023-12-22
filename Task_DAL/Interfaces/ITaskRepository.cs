using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_DAL.Entities;

namespace Task_DAL.Interfaces
{
    public interface ITaskRepository
    {
        IEnumerable<TaskEntity> GetAll();
        TaskEntity? GetById(int id);
        TaskEntity? Insert(TaskEntity task);
        bool Update(TaskEntity task, int id);
        bool Delete(int id);
    }
}
