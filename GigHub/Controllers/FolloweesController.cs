using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;
using GigHub.Core;
using GigHub.Core.Models;
using GigHub.Persistence;

namespace GigHub.Controllers
{
    public class FolloweesController : Controller
    {
        // GET: Followees
        private readonly IUnitOfWork _unitOfWork;

        public FolloweesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        {

            var userId = User.Identity.GetUserId();
            var artists = _unitOfWork.Users.GetArtistsFollowedBy(userId);
            return View(artists);
        }
    }
}