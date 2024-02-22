/*using Assignment.DataAccessLayer.Infrastructure.IRepository;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentEF.Controllers
{
    public class POItemsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public POItemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Poitem> objects = _unitOfWork.POitemsRepository.GetAll();
            return View(objects);
        }
        public IActionResult Details(int? id)
        {
            Poitem? poitem = _unitOfWork.POitemsRepository.GetEntity(x => x.Poid == id);
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Poitem obj)
        {
            string message = _unitOfWork.POitemsRepository.Cretae(obj);
            if (message == "Succesfully")
            {
                _unitOfWork.Save();
            }
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update([FromBody] Poitem obj)
        {
            _unitOfWork.POitemsRepository.Update(obj);
            return View();
        }
        public IActionResult Delete(Poitem obj)
        {
            _unitOfWork.POitemsRepository.Delete(obj);
            return View();
        }
    }
}
*/