using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_BLL.Models;
using Task_DAL.Entities;

namespace Task_BLL.Interfaces
{
    public interface ITaskService
    {
        IEnumerable<TaskModel> GetAll();
        TaskModel? GetById(int id);
        TaskModel? Insert(TaskModel task);
        bool Update(TaskModel task, int id);
        bool Delete(int id);
    }
}
