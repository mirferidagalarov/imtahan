using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.Entities
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        public DateTime ExamDate { get; set; }
        public int Score { get; set; }
        public Lesson Lesson { get; set; }
        [ForeignKey("Lesson")]
        public int LessonId { get; set; }
        public Pupil Pupil { get; set; }
        [ForeignKey("Pupil")]
        public int PupilId { get; set; }
        public bool IsDeleted { get; set; }

    }
}
