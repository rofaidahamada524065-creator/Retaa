using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleAttendance.Models;
using SimpleAttendance.Repo;
using SimpleAttendance.Repo.IRepo;

namespace SimpleAttendance.Controllers
{
    public class StudentController : Controller
    {
        readonly IStudentRepo _studentRepo;
        public StudentController(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }
        // GET: StudentController
        public ActionResult Index()
        {
            var data = _studentRepo.GetAll();
            return View(data);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student s)
        {
            _studentRepo.Add(s);
            return RedirectToAction("Index");
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            var x=_studentRepo.GetById(id);
            return View(x);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student s)
        {
            _studentRepo.Update(s);
            return RedirectToAction("Index");
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            _studentRepo.Delete(id);
            return RedirectToAction("Index");
        }

        // POST: StudentController/Delete/5
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
