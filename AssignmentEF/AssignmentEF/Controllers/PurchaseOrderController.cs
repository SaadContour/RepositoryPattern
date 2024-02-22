/*using Assignment.DataAccessLayer.Infrastructure.IRepository;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentEF.Controllers
{
    public class PurchaseOrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public PurchaseOrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<PurchaseOrder> objects = _unitOfWork.PurchaseOrderRepository.GetAll();
            return View(objects);
        }
*//*        public IActionResult Details(int? id)
        {
            PurchaseOrder? purchaseOrder = _unitOfWork.PurchaseOrderRepository.GetEntity(x => x.Poid == id);
            return View();
        }*//*
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PurchaseOrder obj)
        {
            string message = _unitOfWork.PurchaseOrderRepository.Cretae(obj);
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
        public IActionResult Update([FromBody] PurchaseOrder obj)
        {
            _unitOfWork.PurchaseOrderRepository.Update(obj);
            return View();
        }
        public IActionResult Delete(PurchaseOrder obj)
        {
            _unitOfWork.PurchaseOrderRepository.Delete(obj);
            return View();
        }
    }
}*/