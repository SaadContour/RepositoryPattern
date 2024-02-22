/*using Assignment.DataAccessLayer.Infrastructure.IRepository;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentEF.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CompanyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Company> objects = _unitOfWork.CompanyRepository.GetAll();
            return View(objects);
        }
        public IActionResult Details(int? id) 
        {
            Company? company = _unitOfWork.CompanyRepository.GetEntity(x => x.Id == id);
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Company obj)
        {
           string message = _unitOfWork.CompanyRepository.Cretae(obj);
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
        public IActionResult Update([FromBody] Company obj)
        {
            _unitOfWork.CompanyRepository.Update(obj);
            return View();
        }
        public IActionResult Delete(Company obj) 
        {
            _unitOfWork.CompanyRepository.Delete(obj);
            return View();
        }
    }
}*/