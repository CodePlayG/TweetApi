using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TweetApi.Models
{
    public class Response
    {
        public int Status { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
