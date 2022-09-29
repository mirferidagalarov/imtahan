using Imtahan_Proqrami.DAL.DatabaseContext;
using Imtahan_Proqrami.DAL.Repositories.IRepositories;
using Imtahan_Proqrami.Entities;
using Imtahan_Proqrami.UnitOfWorks.IUnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.DAL.Repositories
{
    public class ExamRepository: IExamRepository
    {
        private readonly DataContext _dataContext;
        private readonly IUnitOfWork _unitOfWork;
        public ExamRepository(DataContext dataContext,IUnitOfWork unitOfWork)
        {
            _dataContext = dataContext;
            _unitOfWork = unitOfWork;
        }

        public async Task Add(Exam exam)
        {
            await _dataContext.Exams.AddAsync(exam);
            await _unitOfWork.Commit();
         
        }

        public async Task Delete(int examId)
        {
            Exam exam = await _dataContext.Exams.FindAsync(examId);
            exam.IsDeleted = true;
            _dataContext.Exams.Update(exam);
            await _unitOfWork.Commit();
        }

        public async Task<List<Exam>> Get()
        {
            List<Exam> exams = await _dataContext.Exams.Include(m => m.Lesson).Include(m => m.Pupil).ToListAsync();
            return exams;
        }

        public async Task<Exam> GetId(int examId)
        {
            return await _dataContext.Exams.FindAsync(examId);
        }

        public async Task Update(Exam exam)
        {
            _dataContext.Exams.Update(exam);
            await _unitOfWork.Commit();
        }
    }
}
