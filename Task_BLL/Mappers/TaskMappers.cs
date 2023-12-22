using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_BLL.Models;
using Task_DAL.Entities;

namespace Task_BLL.Mappers
{
    internal static class TaskMappers
    {
        internal static TaskModel ToTaskModel(this TaskEntity task)
        {
            return new TaskModel(task.TaskId, task.Title, task.Description, task.IsComplete);
        }

        internal static TaskEntity ToTaskEntity(this TaskModel task)
        {
            return new TaskEntity()
            {
                Title = task.Title,
                Description = task.Description,
            };
        }
    }
}
