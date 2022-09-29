using Imtahan_Proqrami.BLL.Abstract;
using Imtahan_Proqrami.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.Controllers
{
    public class ExamController : Controller
    {
        private readonly IExamService _examService;
        private readonly ILessonService _lessonService;
        private readonly IPupilService _pupilService;
        public ExamController(IExamService examService, ILessonService lessonService, IPupilService pupilService)
        {
            _examService = examService;
            _lessonService = lessonService;
            _pupilService = pupilService;
        }
        public async Task<IActionResult> Index()
        {
            List<ExamToListDTO> exams = await _examService.Get();
            return View(exams);
        }

        public async Task<IActionResult> AddExam()
        {
            List<LessonToListDTO> lessonToListDTOs = await _lessonService.Get();
            List<PupilToListDTO> pupilToListDTOs = await _pupilService.Get();
            ExamToAddDTO examToAddDTO = new ExamToAddDTO();
            examToAddDTO.Lessons = lessonToListDTOs;
            examToAddDTO.Pupils = pupilToListDTOs;
            return View(examToAddDTO);
        }

        public async Task<IActionResult>Add(ExamToAddDTO examToAddDTO)
        {
            await _examService.Add(examToAddDTO);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateExam(int id)
        {
            List<LessonToListDTO> lessonToListDTOs = await _lessonService.Get();
            List<PupilToListDTO> pupilToListDTOs = await _pupilService.Get();
            ExamToUpdateDTO exam = await _examService.GetId(id);
            exam.Lessons = lessonToListDTOs;
            exam.Pupils = pupilToListDTOs;
            return View(exam);
        }

        public async Task<IActionResult> Update(ExamToUpdateDTO examToUpdateDTO)
        {
            await _examService.Update(examToUpdateDTO);
            return RedirectToAction("Index");    
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _examService.Delete(id);
            return RedirectToAction("Index");     
        }


    }
}
