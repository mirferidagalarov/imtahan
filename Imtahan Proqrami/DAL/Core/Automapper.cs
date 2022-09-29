using AutoMapper;
using Imtahan_Proqrami.Entities;
using Imtahan_Proqrami.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.DAL.Core
{
    public class Automapper : Profile
    {
        public Automapper()
        {
            CreateMap<Lesson, LessonToListDTO>();
            CreateMap<LessonToAddDTO, Lesson>();
            CreateMap<LessonToUpdateDTO, Lesson>();
            CreateMap<Pupil, PupilToListDTO>();
            CreateMap<PupilToAddDTO, Pupil>();
            CreateMap<PupilToUpdateDTO, Pupil>();
            CreateMap<Exam, ExamToListDTO>().ForMember(dest => dest.ExamDate, opt => opt.MapFrom(src => src.ExamDate.ToString("dd-MMM-yyyy"))); ;
            CreateMap<ExamToAddDTO, Exam>();
            CreateMap<ExamToUpdateDTO, Exam>();
        }
    }
}
