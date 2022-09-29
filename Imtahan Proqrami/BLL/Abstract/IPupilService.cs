using Imtahan_Proqrami.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.BLL.Abstract
{
    public interface IPupilService
    {
        Task<List<PupilToListDTO>> Get();
        Task<PupilToUpdateDTO> GetId(int pupilId);
        Task Add(PupilToAddDTO pupilToAddDTO);
        Task Update(PupilToUpdateDTO pupilToUpdateDTO);
        Task Delete(int pupilId);

    }
}
