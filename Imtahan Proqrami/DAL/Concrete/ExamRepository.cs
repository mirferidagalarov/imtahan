using Imtahan_Proqrami.DAL.Abstract;
using Imtahan_Proqrami.DAL.DatabaseContext;
using Imtahan_Proqrami.DAL.GenericRepositories.Concrete;
using Imtahan_Proqrami.Entities;
using Imtahan_Proqrami.UnitOfWork.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.DAL.Concrete
{
    public class ExamRepository : GenericRepository<Exam>,IExamRepository
    {
        private readonly DataContext _dataContext;
        
        public ExamRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Exam>> GetAll()
        {
            List<Exam> exams = await _dataContext.Exams.Include(m => m.Lesson).Include(m => m.Pupil).ToListAsync();
            return exams;
        }
    }
}
