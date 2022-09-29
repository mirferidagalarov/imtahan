using Imtahan_Proqrami.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.BLL.Services.IServices
{
    public interface ILessonService
    {
        Task<List<LessonToListDTO>> Get();
        Task<LessonToUpdateDTO> GetId(int lessonId);
        Task Add(LessonToAddDTO lessonToAddDTO);
        Task Update(LessonToUpdateDTO lessonToUpdateDTO);
        Task Delete(int lessonId);
    }
}
