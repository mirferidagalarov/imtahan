using Imtahan_Proqrami.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.DAL.Repositories.IRepositories
{
    public interface IPupilRepository
    {
        Task<List<Pupil>> Get();
        Task<Pupil> GetId(int pupilId);
        Task Add(Pupil pupil);
        Task Update(Pupil pupil);
        Task Delete(int pupilId);
    }
}
