using System;
using System.Collections.Generic;

namespace TweetApi.Models
{ 
    public class Tweet
    {
        public Guid Id { get; set; }
        public string TweetText { get; set; }

        public List<string> Tags { get; set; }

        public string Email { get; set; }

        public int Likes { get; set; }

        public List<string> Replies { get; set; }
    }     
}