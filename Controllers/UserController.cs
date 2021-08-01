using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using TweetApi.Models;
using Microsoft.EntityFrameworkCore;
using TweetApi.Data;

namespace TweetApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private ILogger<UserController> Logger { get; }
        IUserRepository UserRepository { get; }
        //DbSet<User> Users
        private static List<User> DemoUsers = new List<User>()
        {
            // new User{ Email="abc@xyz.com", Password="abc"} };
        };

        public UserController(ILogger<UserController> logger, IUserRepository repository)
        {
            Logger = logger;
            UserRepository = repository;
        }

        //[HttpGet]
        //[Route("controller/action/{emailId}")]
        //getMethod?
        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] Login login)
        {
            return Ok(UserRepository.Login(login));

            //var log = DemoUsers.Where(x => x.LoginInfo.Email.Equals(login.Email) && x.LoginInfo.Password.Equals(login.Password)).FirstOrDefault();

            //if (log == null)
            //{
            //    return Ok(new { status = 401, isSuccess = false, message = "Invalid User", });
            //}
            //else
            //{
            //    return Ok(new { status = 200, isSuccess = true, message = "User Login successfully" });
            //}
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register([FromBody] User user)
        {
            return Ok(UserRepository.Register(user));
            //Response response = null;
            //try
            //{
            //    if (DemoUsers.Exists(x => x.LoginInfo.Email.Equals(user.LoginInfo.Email)))
            //    {
            //        response = new Response { Status = 400, IsSuccess = false, Message = "Email already exist." };
            //        return Ok(response);
            //    }
            //    else
            //    {
            //        DemoUsers.Add(user);
            //        return Ok(new { status = 201, isSuccess = true, message = "User Registered." });
            //    }
            //}
            //catch (Exception)
            //{
            //    return Ok(new { status = 200, isSuccess = false, message = "Error, please let" });
            //    throw;
            //}
            //// return Ok(new { status = "Error", isSuccess=false,message = "Error, please let" });
        }


    }
}
