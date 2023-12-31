﻿using System.ComponentModel.DataAnnotations;

namespace Task_API.Models.Forms
{
    public class CreateTaskForm
    {
        #nullable disable

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
