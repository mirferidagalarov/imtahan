using Imtahan_Proqrami.BLL.Services.IServices;
using Imtahan_Proqrami.DAL.Repositories.IRepositories;
using Imtahan_Proqrami.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.UnitOfWorks.IUnitOfWorks
{
    public interface IUnitOfWork:IDisposable
    {
         ILessonRepository LessonRepository { get;}
         IPupilRepository PupilRepository { get; }
         IExamRepository ExamRepository { get; }

        Task<int> Commit();

    }
}
