using Imtahan_Proqrami.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.DAL.Repositories.IRepositories
{
    public interface ILessonRepository
    {
        Task<List<Lesson>> GetList();
        Task<Lesson> GetId(int lessonId);
        Task Add(Lesson lesson);
        Task Update(Lesson lesson);
        Task Delete(int lessonId);

    }
}
