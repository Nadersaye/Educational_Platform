using System;
using System.Collections.Generic;

namespace Educational_Platform.ViewModel
{
    public class CourseDetailsViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string Image { get; set; } // Ensure this property is included
        public List<LessonViewModel> Lessons { get; set; } = new List<LessonViewModel>();
    }
}
