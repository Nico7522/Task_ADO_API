using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_DAL.Entities;

namespace Task_DAL.Mappers
{
    internal static class TaskMappers
    {
        internal static TaskEntity ToTaskEntity(this IDataRecord record)
        {
            return new TaskEntity()
            {
                TaskId = (int)record["Task_Id"],
                Title = (string)record["Title"],
                Description = (string)record["Description"],
                IsComplete = (bool)record["IsComplete"]
            };
        }
    }
}
