using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.Entities
{
    public class Lesson
    {
        [Key]
        public int LessonId { get; set; }
        public int LessonCode { get; set; }
        public string LessonName { get; set; }
        public int Class { get; set; }
        public string LessonTeacherName { get; set; }
        public string LessonTeacherSurname { get; set; }
        public bool IsDeleted { get; set; }

    }
}
