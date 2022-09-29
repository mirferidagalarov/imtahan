using Imtahan_Proqrami.BLL.Services.IServices;
using Imtahan_Proqrami.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.Controllers
{
    public class LessonController : Controller
    {
        private readonly ILessonService _lessonService;
        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }
        public async  Task<IActionResult> Index()
        {
            List<LessonToListDTO> lessons = await _lessonService.Get();
            return View(lessons);
        }
        public IActionResult AddLesson()
        {
            return View();
        }

        public async Task<IActionResult> Add(LessonToAddDTO lessonToAddDTO)
        {
            await _lessonService.Add(lessonToAddDTO);
            return RedirectToAction("Index");
        }
         
        public async Task<IActionResult> UpdateLesson(int id)
        {
            LessonToUpdateDTO lesson = await _lessonService.GetId(id);
            return View(lesson);
        }
        public async Task<IActionResult> Update(LessonToUpdateDTO lessonToUpdateDTO)
        {
            await _lessonService.Update(lessonToUpdateDTO);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _lessonService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
