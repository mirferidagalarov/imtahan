using Imtahan_Proqrami.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.Models
{
    public class ExamToListDTO
    {
        public int ExamId { get; set; }
        public string ExamDate { get; set; }
        public int Score { get; set; }
        public int PupilId { get; set; }
        public int LessonId { get; set; }
        public Pupil Pupil { get; set; }
        public Lesson Lesson { get; set; }
    }
}
