using carro.Models;
using Microsoft.AspNetCore.Mvc;


namespace AppCarro.Controllers
{
    public class CarroController : Controller
    {
        CarroRepository _repository = 
        new CarroRepository();

        public IActionResult Index()
        {
            var carro = _repository.GetAll();          

            return View(carro);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Carro carro)
        {
            _repository.Create(carro);

            return RedirectToAction("index");
        }

       [HttpGet]
        public IActionResult Edit( int id)
        {      // car
            var carro = _repository.GetById(id);
            return View(carro);
        }

        [HttpPost]
        public IActionResult Edit(Carro carroAlterado)
        {
            _repository.Update(carroAlterado);

            return RedirectToAction("index");
        }


        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    
    }
}