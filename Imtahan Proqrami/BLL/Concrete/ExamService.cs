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
    public class ExamService : IExamService
    {
        private readonly IUnitOfWorks _unitOfWork;
        private readonly IMapper _mapper;
        public ExamService(IUnitOfWorks  unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Add(ExamToAddDTO examToAddDTO)
        {
            Exam exam = _mapper.Map<Exam>(examToAddDTO);
            await _unitOfWork.ExamRepository.Add(exam);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int examId)
        {
            await _unitOfWork.ExamRepository.Delete(examId);
            await _unitOfWork.CommitAsync();
        }

        public async Task<List<ExamToListDTO>> Get()
        {
            List<Exam> exams = await _unitOfWork.ExamRepository.GetAll();
            return _mapper.Map<List<ExamToListDTO>>(exams);
        }

        public async Task<ExamToUpdateDTO> GetId(int examId)
        {
            Exam exam = await _unitOfWork.ExamRepository.GetId(examId);
            return _mapper.Map<ExamToUpdateDTO>(exam);
        }

        public async Task Update(ExamToUpdateDTO examToUpdateDTO)
        {
            Exam exam = _mapper.Map<Exam>(examToUpdateDTO);
            await _unitOfWork.ExamRepository.Update(exam);
            await _unitOfWork.CommitAsync();
        }
    }
}
