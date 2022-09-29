using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.Models
{
    public class ExamToAddDTO
    {
        public DateTime ExamDate { get; set; }
        public int Score { get; set; }
        public int LessonId { get; set; }
        public int PupilId { get; set; }
        public List<LessonToListDTO> Lessons { get; set; }
        public List<PupilToListDTO> Pupils { get; set; }

    }
}
