using Microsoft.AspNetCore.Mvc;
using Assignment.DataAccessLayer.Infrastructure.IRepository;
using Assignment.Models;

namespace AssignmentEF.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Category> objects = await _unitOfWork.CategoryRepository.GetAll();
            return View(objects);
        }
        public async Task<IActionResult> Details(int? id)
        {
            Category? category = await _unitOfWork.CategoryRepository.GetEntity(x => x.Id == id);
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category obj)
        {
            string message = await _unitOfWork.CategoryRepository.Cretae(obj);
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
        public IActionResult Update([FromBody] Category obj)
        {
            _unitOfWork.CategoryRepository.Update(obj);
            return View();
        }
        public IActionResult Delete(Category obj)
        {
            _unitOfWork.CategoryRepository.Delete(obj);
            return View();
        }
    }
}
