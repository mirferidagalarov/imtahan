using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.Models
{
    public class LessonToAddDTO
    {
        public int LessonCode { get; set; }
        public string LessonName { get; set; }
        public int Class { get; set; }
        public string LessonTeacherName { get; set; }
        public string LessonTeacherSurname { get; set; }
    }
}
