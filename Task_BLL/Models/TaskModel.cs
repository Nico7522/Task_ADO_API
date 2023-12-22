using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_BLL.Models
{
    public class TaskModel {

        #nullable disable
        public int TaskId { get; }
        public string Title { get; }
        public string Description { get; }
        public bool IsComplete { get; }

        public TaskModel(string title, string description)
        {
            Title = title;
            Description = description;
        }
        public TaskModel(int taskId, string title, string description, bool isComplete) : this (title, description)
        {
            TaskId = taskId;
            IsComplete = isComplete;
        }

     
    }
}
