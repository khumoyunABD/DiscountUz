using DiscountUz.DataAccess.Repository.IRepository;
using DiscountUz.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DiscountUzWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class FavItemController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public FavItemVM FavItemVM { get; set; }
        public FavItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            FavItemVM = new FavItemVM()
            {
                ItemList = _unitOfWork.FavItem.GetAll(u => u.ApplicationUserId == claim.Value,
                includeProperties: "Product")
            };
            return View(FavItemVM);
        }

        public IActionResult Remove(int itemId) 
        {
            var item = _unitOfWork.FavItem.GetFirstOrDefault(u => u.Id == itemId);
            _unitOfWork.FavItem.Remove(item);
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
