using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.Models
{
    public class LessonToUpdateDTO
    {
        public int LessonId { get; set; }
        public int LessonCode { get; set; }
        public string LessonName { get; set; }
        public int Class { get; set; }
        public string LessonTeacherName { get; set; }
        public string LessonTeacherSurname { get; set; }
    }
}
