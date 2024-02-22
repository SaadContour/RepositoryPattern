/*using Assignment.DataAccessLayer.Infrastructure.IRepository;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentEF.Controllers
{
    public class DeliveryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeliveryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Delivery> objects = _unitOfWork.DeliveryRepository.GetAll();
            return View(objects);
        }
    *//*    public IActionResult Details(int? id)
        {
            Delivery? delivery = _unitOfWork.DeliveryRepository.GetEntity(x => x.Did == id);
            return View();
        }*//*
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Delivery obj)
        {
            string message = _unitOfWork.DeliveryRepository.Cretae(obj);
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
        public IActionResult Update([FromBody] Delivery obj)
        {
            _unitOfWork.DeliveryRepository.Update(obj);
            return View();
        }
        public IActionResult Delete(Delivery obj)
        {
            _unitOfWork.DeliveryRepository.Delete(obj);
            return View();
        }
    }
}
*/