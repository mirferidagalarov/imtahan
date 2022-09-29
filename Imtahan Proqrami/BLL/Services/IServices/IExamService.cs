using Imtahan_Proqrami.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.BLL.Services.IServices
{
    public interface IExamService
    {
        Task<List<ExamToListDTO>> Get();
        Task<ExamToUpdateDTO> GetId(int examId);
        Task Add(ExamToAddDTO  examToAddDTO);
        Task Update(ExamToUpdateDTO  examToUpdateDTO);
        Task Delete(int examId);
    }
}
