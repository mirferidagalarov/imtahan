using Imtahan_Proqrami.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.DAL.Repositories.IRepositories
{
    public interface IExamRepository
    {
        Task<List<Exam>> Get();
        Task<Exam> GetId(int examId);
        Task Add(Exam exam);
        Task Update(Exam exam);
        Task Delete(int examId);
    }
}
