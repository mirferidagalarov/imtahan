using AutoMapper;
using Imtahan_Proqrami.BLL.Abstract;
using Imtahan_Proqrami.DAL.Abstract;
using Imtahan_Proqrami.Entities;
using Imtahan_Proqrami.Models;
using Imtahan_Proqrami.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.BLL.Concrete
{
    public class LessonService : ILessonService
    {
        private readonly IUnitOfWorks _unitOfWork;
        private readonly IMapper _mapper;
        public LessonService(IUnitOfWorks  unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Add(LessonToAddDTO lessonToAddDTO)
        {
            Lesson lesson = _mapper.Map<Lesson>(lessonToAddDTO);
            await _unitOfWork.LessonRepository.Add(lesson);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int lessonId)
        {
            await _unitOfWork.LessonRepository.Delete(lessonId);
            await _unitOfWork.CommitAsync();
        }

        public async Task<List<LessonToListDTO>> Get()
        {
            List<Lesson> lessons = await _unitOfWork.LessonRepository.Get();
            return _mapper.Map<List<LessonToListDTO>>(lessons);
        }

        public async Task<LessonToUpdateDTO> GetId(int lessonId)
        {
            Lesson lesson = await _unitOfWork.LessonRepository.GetId(lessonId);
            return _mapper.Map<LessonToUpdateDTO>(lesson);
        }

        public async Task Update(LessonToUpdateDTO lessonToUpdateDTO)
        {
            Lesson lesson = _mapper.Map<Lesson>(lessonToUpdateDTO);
            await _unitOfWork.LessonRepository.Update(lesson);
            await _unitOfWork.CommitAsync();
        }
    }
}
