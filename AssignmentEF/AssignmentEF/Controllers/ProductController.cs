using Assignment.DataAccessLayer.Infrastructure.IRepository;
using Assignment.Models;
using AssignmentEF.ViewModel;
using AutoMapper;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentEF.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mappingConfig;
        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, IMapper mappingConfig)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _mappingConfig = mappingConfig;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> objects = await _unitOfWork.ProductRepository.GetAll();
            return View(objects);
        }
       /* public IActionResult Details(int? id)
        {
            Product? product = _unitOfWork.ProductRepository.GetEntity(x => x.Pid == id);
            return View();
        }*/
        public async Task<IActionResult> Create()
        {
            IEnumerable<Category> products = await _unitOfWork.CategoryRepository.GetAll();
            ViewBag.Categories = new SelectList(products,"Id" , "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel obj)
        {
            //Product? product = _mappingConfig.Map<Product>(obj);
            string ImagePath = UploadFile(obj.Image, "Images");
            Product product = new Product
            {
                Name = obj.Name,
                CategoryId = obj.CategoryId,
                Quality = obj.Quality,
                Quantity = obj.Quantity,
                Colour = obj.Colour,
                Price = obj.Price,
                Image = ImagePath,
                Description = obj.Description,
            };
            string message = await _unitOfWork.ProductRepository.Cretae(product);
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
        public IActionResult Update([FromBody] Product obj)
        {
            _unitOfWork.ProductRepository.Update(obj);
            return View();
        }
        public IActionResult Delete(Product obj)
        {
            _unitOfWork.ProductRepository.Delete(obj);
            return View();
        }

        public string UploadFile(IFormFile file, string subDirectory)
        {
            string? fileName = null;
            if(file != null)
            {
            /*C: \Users\siddjsaa\OneDrive - PERSEUS MANAGEMENT GROUP INC\C#.Net\AssignmentEF\AssignmentEF\wwwroot\Images\*/
            /*C: \Users\siddjsaa\OneDrive - PERSEUS MANAGEMENT GROUP INC\C#.Net\AssignmentEF\AssignmentEF\wwwroot\Images*/
                string UploadDirectory = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
                fileName = Guid.NewGuid().ToString() + "-" + file.FileName;
                string FilePath = Path.Combine(UploadDirectory, fileName);
                using(var fileStream = new FileStream(FilePath,FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }

            return fileName;
        }
    }
}
