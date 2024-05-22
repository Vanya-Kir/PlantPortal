using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plant;

namespace PlantPortal.Controllers
{
    public class PlantReferenceBookController : Controller
    {
        private readonly IPlantRepository plantRepository;

        public PlantReferenceBookController(IPlantRepository plantRepository)
        {
            this.plantRepository = plantRepository;
        }

        // GET: PlantReferenceBookController
        public ActionResult Index(string query)
        {
            var plants = plantRepository.GetAllByName(query);
            return View(plants);
        }

        // GET: PlantReferenceBookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlantReferenceBookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlantReferenceBookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: PlantReferenceBookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlantReferenceBookController/Edit/5
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

        // GET: PlantReferenceBookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlantReferenceBookController/Delete/5
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
