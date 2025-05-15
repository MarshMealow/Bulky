using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BulkyWeb.Models;
using SD7501Bulky.DataAccess.Repositry.IRespositry;
using SD7501Bulky.Models;

namespace BulkyWeb.Areas.Customer.Controllers;
[Area("Customer")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includingProperties: "Category");
        return View(productList);
    }

    public IActionResult Details(int productId)
    {
        Product product = _unitOfWork.Product.Get(u=> u.Id == productId, includingProperties: "Category");
        return View(product);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
