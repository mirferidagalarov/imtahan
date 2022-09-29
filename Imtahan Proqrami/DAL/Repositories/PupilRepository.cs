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
    public class PupilRepository : IPupilRepository
    {
        private readonly DataContext _dataContext;
        private readonly IUnitOfWork _unitOfWork;
        public PupilRepository(DataContext dataContext, IUnitOfWork unitOfWork)
        {
            _dataContext = dataContext;
            _unitOfWork = unitOfWork;
        }

        public async Task Add(Pupil pupil)
        {
            await _dataContext.Pupils.AddAsync(pupil);
            await _unitOfWork.Commit();
        }

        public async Task Delete(int pupilId)
        {
            Pupil pupil = await _dataContext.Pupils.FindAsync(pupilId);
            pupil.IsDeleted = true;
            _dataContext.Update(pupil);
            await _unitOfWork.Commit();

        }

        public async Task<List<Pupil>> Get()
        {
            List<Pupil> pupils = await _dataContext.Pupils.ToListAsync();
            return pupils;
        }

        public async Task<Pupil> GetId(int pupilId)
        {
            return await _dataContext.Pupils.FindAsync(pupilId);
        }

        public async Task Update(Pupil pupil)
        {
            _dataContext.Pupils.Update(pupil);
            await _unitOfWork.Commit();
        }
    }
}
