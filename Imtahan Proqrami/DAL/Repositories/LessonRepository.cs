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
    public class LessonRepository: ILessonRepository
    {
        private readonly DataContext _dataContext;
        private readonly IUnitOfWork _unitOfWork;
        public LessonRepository(DataContext dataContext, IUnitOfWork unitOfWork)
        {
            _dataContext = dataContext;
            _unitOfWork = unitOfWork;
        }

        public async Task Add(Lesson lesson)
        {
            await _dataContext.Lessons.AddAsync(lesson);
            await _unitOfWork.Commit();
        }

        public async Task Delete(int lessonId)
        {
            Lesson lesson = await _dataContext.Lessons.FindAsync(lessonId);
            lesson.IsDeleted = true;
            _dataContext.Update(lesson);
            await _unitOfWork.Commit();
        }

        public async Task<Lesson> GetId(int lessonId)
        {
            return await _dataContext.Lessons.FindAsync(lessonId);
        }

        public async Task<List<Lesson>> GetList()
        {
            List<Lesson> lessons = await _dataContext.Lessons.ToListAsync();
            return lessons;
        }

        public async Task Update(Lesson lesson)
        {
            _dataContext.Lessons.Update(lesson);
            await _unitOfWork.Commit();
        }
    }
}
