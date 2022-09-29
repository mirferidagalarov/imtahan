using Imtahan_Proqrami.BLL.Services.IServices;
using Imtahan_Proqrami.DAL.DatabaseContext;
using Imtahan_Proqrami.DAL.Repositories;
using Imtahan_Proqrami.DAL.Repositories.IRepositories;
using Imtahan_Proqrami.UnitOfWorks.IUnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
            
        }
        public ILessonRepository LessonRepository { get; private set; }

        public IPupilRepository PupilRepository { get; private set; }

        public IExamRepository ExamRepository { get; private set; }

        public async Task<int> Commit()
        {
              return  await _dataContext.SaveChangesAsync();
        }

        public  void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
