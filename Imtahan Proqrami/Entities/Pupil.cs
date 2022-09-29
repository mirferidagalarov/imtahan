using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.Entities
{
    public class Pupil
    {
        [Key]
        public int PupilId { get; set; }
        public int PupilNumber { get; set; }
        public int Class { get; set; }
        public string PupilName { get; set; }
        public string PupilSurname { get; set; }      
        public bool IsDeleted { get; set; }
    }
}
