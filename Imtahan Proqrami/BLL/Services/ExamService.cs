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
    public class ExamService: IExamService
    {
        private readonly IExamRepository _examRepository;
        private readonly IMapper _mapper;
        public ExamService(IExamRepository examRepository, IMapper mapper)
        {
            _examRepository = examRepository;
            _mapper = mapper;
        }

        public async Task Add(ExamToAddDTO examToAddDTO)
        {
            Exam exam = _mapper.Map<Exam>(examToAddDTO);
            await _examRepository.Add(exam);
        }

        public async Task Delete(int examId)
        {
            await _examRepository.Delete(examId);
        }

        public async Task<List<ExamToListDTO>> Get()
        {
            List<Exam> exams = await _examRepository.Get();
            return _mapper.Map<List<ExamToListDTO>>(exams);
        }

        public async Task<ExamToUpdateDTO> GetId(int examId)
        {
            Exam exam = await _examRepository.GetId(examId);
            return _mapper.Map<ExamToUpdateDTO>(exam);
        }

        public async Task Update(ExamToUpdateDTO examToUpdateDTO)
        {
            Exam exam = _mapper.Map<Exam>(examToUpdateDTO);
            await _examRepository.Update(exam);
        }
    }
}
