using Imtahan_Proqrami.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.Models
{
    public class PupilToListDTO
    {
        public int PupilId { get; set; }
        public int PupilNumber { get; set; }
        public int Class { get; set; }
        public string PupilName { get; set; }
        public string PupilSurname { get; set; }
       
    }
}
