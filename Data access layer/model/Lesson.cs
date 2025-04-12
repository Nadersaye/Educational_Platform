﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_access_layer.model
{
    public class Lesson
    {
        [Key]
        public int ID { get; set; }


        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string VideoURL { get; set; }

        public string SupportingFiles { get; set; }

        public int OrderNumber { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public int CourseID { get; set; }

        public Course Course { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
