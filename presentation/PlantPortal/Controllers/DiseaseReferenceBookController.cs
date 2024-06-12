using Microsoft.AspNetCore.Mvc;
using Plant;
using Plant.Ml;

namespace PlantPortal.Controllers
{
    public class DiseaseReferenceBookController : Controller
    {
        private readonly DiseaseService diseaseService;

        public DiseaseReferenceBookController(DiseaseService diseaseService)
        {
            this.diseaseService = diseaseService;
        }

        public ActionResult Index()
        {
            var disease = diseaseService.GetAllDisease();
            return View("Index", disease);
        }

        public ActionResult Search(string name)
        {
            var disease = diseaseService.GetAllDiseaseByName(name);
            return View("Index", disease);
        }

        public ActionResult Details(long id)
        {
            var disease = diseaseService.GetDiseaseById(id);
            return View(disease);
        }

        // POST: PlantReferenceBookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Predict(IFormCollection collection)
        {
            try
            {
                //todo
                byte[] imageBytes = null;
                MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
                {
                    ImageSource = imageBytes,
                };

                // Make a single prediction on the sample data and print results.
                var sortedScoresWithLabel = MLModel1.PredictAllLabels(sampleData);


                return View(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
