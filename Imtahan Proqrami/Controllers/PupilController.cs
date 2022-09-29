using Imtahan_Proqrami.BLL.Services.IServices;
using Imtahan_Proqrami.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.Controllers
{
    public class PupilController : Controller
    {
        private readonly IPupilService  _pupilService;
        private readonly ILessonService  _lessonService;
        public PupilController(IPupilService pupilService, ILessonService lessonService)
        {
            _lessonService = lessonService;
            _pupilService = pupilService;
        }
         public async Task<IActionResult> Index()
        {
            List<PupilToListDTO> pupil = await _pupilService.Get();                     
            return View(pupil);
        }

        public  IActionResult AddPupil()
        {
            return View();
        }

        public async Task<IActionResult> Add(PupilToAddDTO  pupilToAddDTO)
        {
            await _pupilService.Add(pupilToAddDTO);            
            return RedirectToAction("Index");          

        }

        public async Task<IActionResult> UpdatePupil(int id)
        {
            PupilToUpdateDTO pupil = await _pupilService.GetId(id);
            return View(pupil);
        }

        public async Task<IActionResult> Update(PupilToUpdateDTO  pupilToUpdateDTO)
        {         
            await _pupilService.Update(pupilToUpdateDTO);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Delete(int id)
        {
            await _pupilService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
