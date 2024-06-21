using Device;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace PlantPortal.Controllers
{
    public class DeviceController : Controller
    {
        private readonly IHumidityRepository humidityRepository;
        private readonly ITemperatureRepository temperatureRepository;

        public DeviceController(IHumidityRepository humidityRepository, ITemperatureRepository temperatureRepository)
        {
            this.humidityRepository = humidityRepository;
            this.temperatureRepository = temperatureRepository;
        }

        // GET: DeviceController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Humidity()
        {
            var userId = User.FindFirstValue((ClaimTypes.NameIdentifier));
            if (!string.IsNullOrEmpty(userId))
            {
                var humidity = humidityRepository.GetAllByUser(userId);
                return View(humidity);
            }
            return View();
        }

        // GET: DeviceController/Create
        public ActionResult Temperature()
        {
            var userId = User.FindFirstValue((ClaimTypes.NameIdentifier));
            if (!string.IsNullOrEmpty(userId))
            {
                var temperature = temperatureRepository.GetAllByUser(userId);
                return View(temperature);
            }
            return View();
        }

        // POST: DeviceController/Create
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

        // GET: DeviceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeviceController/Edit/5
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

        // GET: DeviceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeviceController/Delete/5
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
