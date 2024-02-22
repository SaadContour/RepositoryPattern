/*using Assignment.DataAccessLayer.Infrastructure.IRepository;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentEF.Controllers
{
    public class DeliveryItems : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeliveryItems(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<DeliveryItem> objects = _unitOfWork.deliveryItemsRepository.GetAll();
            return View(objects);
        }
        public IActionResult Details(int? id)
        {
            DeliveryItem? deliveryItem = _unitOfWork.deliveryItemsRepository.GetEntity(x => x.Did == id);
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DeliveryItem obj)
        {
            string message = _unitOfWork.deliveryItemsRepository.Cretae(obj);
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
        public IActionResult Update([FromBody] DeliveryItem obj)
        {
            _unitOfWork.deliveryItemsRepository.Update(obj);
            return View();
        }
        public IActionResult Delete(DeliveryItem obj)
        {
            _unitOfWork.deliveryItemsRepository.Delete(obj);
            return View();
        }
    }
}
*/