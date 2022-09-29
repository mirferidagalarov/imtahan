using Imtahan_Proqrami.DAL.Abstract;
using Imtahan_Proqrami.DAL.DatabaseContext;
using Imtahan_Proqrami.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.UnitOfWork.Concrete
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private readonly DataContext _dataContext;
      
        public ILessonRepository LessonRepository { get; private set; }

        public IPupilRepository PupilRepository { get; private set; }

        public IExamRepository ExamRepository { get; private set; }
        private bool isDisposed = false;
        public UnitOfWorks(DataContext dataContext,ILessonRepository lessonRepository,IPupilRepository pupilRepository,IExamRepository examRepository)
        {
            _dataContext = dataContext;
            LessonRepository = lessonRepository;
            PupilRepository = pupilRepository;
            ExamRepository = examRepository;    

        }
        public async Task CommitAsync()
        {
            await _dataContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (!isDisposed)
            {
                isDisposed = true;
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dataContext.Dispose();
            }
        }

        public async ValueTask DisposeAsync()
        {
            if (!isDisposed)
            {
                isDisposed = true;
                await DisposeAsync(true);
                GC.SuppressFinalize(this);
            }
        }

        protected async ValueTask DisposeAsync(bool disposing)
        {
            if (disposing)
            {
                await _dataContext.DisposeAsync();
            }
        }
    }
}
