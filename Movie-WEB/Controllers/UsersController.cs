using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movie_DataAccess.Services.Interface;

namespace Movie_WEB.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
