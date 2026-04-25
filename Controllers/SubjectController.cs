using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleAttendance.Models;
using SimpleAttendance.Repo.IRepo;

namespace SimpleAttendance.Controllers
{
    public class SubjectController : Controller
    {
        readonly ISubjectRepo _subjectRepo;
        public SubjectController(ISubjectRepo subjectRepo)
        {
            _subjectRepo = subjectRepo;
        }
        // GET: SubjectController
        public ActionResult Index()
        {
            var data = _subjectRepo.GetAll();
            return View(data);
        }

        // GET: SubjectController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubjectController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Subject subject)
        {
            _subjectRepo.Add(subject);
            return RedirectToAction("Index");
           
        }

        // GET: SubjectController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: SubjectController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubjectController/Delete/5
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
