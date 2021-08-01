using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using TweetApi.Models;
using TweetApi.Data;

namespace TweetApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TweetsController : Controller
    {
        //public IConfiguration
        private ILogger<TweetsController> logger;

        private ITweetRepository repository;

        public TweetsController(ILogger<TweetsController> logger, ITweetRepository repository)
        {
            this.logger = logger;
            this.repository = repository;
        }

        [HttpGet]
        [Route("All")]
        public IEnumerable<Tweet> AllTweets()
        {

            var allTweets = repository.AllTweets();
            //if (allTweets != null)
            return allTweets;
        }

        [HttpGet]
        [Route("User/All")]
        public IList<Tweet> GetUserAllTweet(string emailId)
        {
            return repository.UserAllTweets(emailId);
        }
        [HttpPost]
        [Route("user/add")]
        public IActionResult AddById(Tweet tweet)
        {
            repository.AddTweet(tweet);

            return Ok();
        }

        //[HttpPut]
        //public IActionResult UpdateTweet(string tweetId)
        //{
        //    return null;
        //}

        //[HttpDelete]
        //public IActionResult DeleteTweet(string tweetId)
        //{
        //    return null;
        //}

        //[HttpPut]
        //public IActionResult LikeTweet(string tweetId)
        //{
        //    return null;
        //}

        //[HttpPost]
        //public IActionResult ReplyTweet(string tweetId)
        //{

        //    return null;
        //}
        ////[HttpGet]
        ////[Route("[controller]/[Action]/{Email}")]
        ////public IEnumerable<Tweet>GetTweets(string email)
        ////{
        ////   // return View();
        ////}
    }
}
