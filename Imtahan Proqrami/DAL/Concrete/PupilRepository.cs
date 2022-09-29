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
    public class PupilRepository : GenericRepository<Pupil>,IPupilRepository
    {
        public PupilRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
