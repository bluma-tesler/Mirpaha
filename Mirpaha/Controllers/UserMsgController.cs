using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mirpaha.Service;
using System.ComponentModel.DataAnnotations;

namespace Mirpaha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMsgController : ControllerBase
    {
        //private readonly EmailService _emailService;
        private readonly IMsgService _msgService;
        public UserMsgController(IMsgService msgService)
        {
            _msgService = msgService;
        }

        [HttpPost]
        public void Login(string msg)
        {
            _msgService.Login(msg);
        }

        [HttpPost("Logout")]
        public void Logout(string msg)
        {
            _msgService.Logout(msg);
        }
    }
}
