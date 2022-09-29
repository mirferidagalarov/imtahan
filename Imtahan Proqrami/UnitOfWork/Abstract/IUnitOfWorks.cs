using Imtahan_Proqrami.DAL.Abstract;
using Imtahan_Proqrami.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.UnitOfWork.Abstract
{
    public interface IUnitOfWorks : IAsyncDisposable
    {
        ILessonRepository LessonRepository { get; }
        IPupilRepository PupilRepository { get; }
        IExamRepository ExamRepository { get; }

        public Task CommitAsync();

    }
}
