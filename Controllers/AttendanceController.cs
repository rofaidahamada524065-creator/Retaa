using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleAttendance.Models;
using SimpleAttendance.Repo.IRepo;
using SimpleAttendance.ViewModel;
using System;
using System.Security.Cryptography;

namespace SimpleAttendance.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly IStudentRepo _studentRepo;
        private readonly ISubjectRepo _subjectRepo;
        private readonly IAttendanceRepo _attendanceRepo;
        public AttendanceController(IStudentRepo studentRepo, ISubjectRepo subjectRepo, IAttendanceRepo attendanceRepo)
        {
            _studentRepo = studentRepo;
            _subjectRepo = subjectRepo;
            _attendanceRepo = attendanceRepo;
        }

        // GET: AttendanceController
        public ActionResult Index(int? sId,int? SubId)
        {
            AttendanceVM attendanceVM = new AttendanceVM
            {
                Studentss = _studentRepo.GetAll(),
                Subjectss = _subjectRepo.GetAll(),
                attendances=_attendanceRepo.GetAll(sId,SubId),
                SubjectId=SubId??0 ,
                StudentId=sId??0
            };
            return View(attendanceVM);
        }

        // GET: AttendanceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AttendanceController/Create
        public ActionResult Create()
        {
            AttendanceVM attendanceVM = new AttendanceVM
            {
                Studentss = _studentRepo.GetAll(),
                Subjectss = _subjectRepo.GetAll(),
                Date=DateTime.Now
                
            };
            return View(attendanceVM);
        }

        // POST: AttendanceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AttendanceVM vm)
        {
            var Att = new Attendance
            {
               
                Date = vm.Date,
                Status = vm.Status,
                StudentId = vm.StudentId,
                SubjectId = vm.SubjectId,

            };
            _attendanceRepo.Add(Att);
            return RedirectToAction("Index");
        }

        // GET: AttendanceController/Edit/5
        public ActionResult Edit(int id)
        {
            var x = _attendanceRepo.GetById(id);

            if (x == null)
                return NotFound();

            var vm = new AttendanceVM
            {
                AttendanceId=x.AttendanceId,
                Date = x.Date,
                Status = x.Status,
                StudentId = x.StudentId,
                SubjectId = x.SubjectId,
                Studentss = _studentRepo.GetAll(),
                Subjectss = _subjectRepo.GetAll()
            };

            return View(vm);
        }

        // POST: AttendanceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AttendanceVM vm)
        {
            var Att = new Attendance
            {

                Date = vm.Date,
                Status = vm.Status,
                StudentId = vm.StudentId,
                SubjectId = vm.SubjectId,

            };
            _attendanceRepo.Update(Att);
            return RedirectToAction("Index");
        }

        // GET: AttendanceController/Delete/5
        public ActionResult Delete(int id)
        {
            _attendanceRepo.Delete(id);
            return RedirectToAction("Index");
        }

        // POST: AttendanceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
