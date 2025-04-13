﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_access_layer.model
{
    public class Revision
    {
        [Key]
        public int ID { get; set; }

        public int CourseID { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string VideoURL { get; set; }

        public string SupportingFiles { get; set; }

        public DateTime? ScheduleDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        [ForeignKey(nameof(CourseID))]
        public virtual Course Course { get; set; }
    }
}
