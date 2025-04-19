﻿using Data_access_layer.model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Educational_Platform.ViewModel
{
    public class LessonViewModel
    {
        
            [Key]
            public int ID { get; set; }

            [Required]
            [StringLength(255)]
            public string Title { get; set; }

            [StringLength(255)]
            public string VideoURL { get; set; } // Ensure this is properly populated
            public string SupportingFiles { get; set; }
            public string TaskFileName { get; set; }
            public DateTime Create_date { get; set; }

            [Required]
            public int CourseID { get; set; } // Add the missing CourseID property

            [ForeignKey("CourseID")]
            public Course Course { get; set; } // Add the missing Course property

            [NotMapped]
            public IFormFile videoFile { get; set; } // Property to handle uploaded video files

            [NotMapped]
            public IFormFile TaskFile { get; set; }

            [NotMapped]
            public IFormFile Files { get; set; } // Property to handle uploaded supporting files
        
    }
}
