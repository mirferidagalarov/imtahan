using AutoMapper;
using Imtahan_Proqrami.BLL.Services.IServices;
using Imtahan_Proqrami.DAL.Repositories.IRepositories;
using Imtahan_Proqrami.Entities;
using Imtahan_Proqrami.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.BLL.Services
{
    public class LessonService: ILessonService
    {
        private readonly ILessonRepository _lessonRepository;
        private readonly IMapper _mapper;
        public LessonService(ILessonRepository lessonRepository, IMapper mapper)
        {
            _lessonRepository = lessonRepository;
            _mapper = mapper;
        }

        public async Task Add(LessonToAddDTO lessonToAddDTO)
        {
            Lesson lesson = _mapper.Map<Lesson>(lessonToAddDTO);
            await _lessonRepository.Add(lesson);
        }

        public async Task Delete(int lessonId)
        {
            await _lessonRepository.Delete(lessonId);
        }

        public async Task<List<LessonToListDTO>> Get()
        {
            List<Lesson> lessons = await _lessonRepository.GetList();
            return _mapper.Map<List<LessonToListDTO>>(lessons);
        }

        public async Task<LessonToUpdateDTO> GetId(int lessonId)
        {
            Lesson lesson = await _lessonRepository.GetId(lessonId);
            return _mapper.Map<LessonToUpdateDTO>(lesson);
        }

        public async Task Update(LessonToUpdateDTO lessonToUpdateDTO)
        {
            Lesson lesson = _mapper.Map<Lesson>(lessonToUpdateDTO);
            await _lessonRepository.Update(lesson);
        }
    }
}
