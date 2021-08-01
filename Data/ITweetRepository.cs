using System.Collections.Generic;
using TweetApi.Models;

namespace TweetApi.Data
{
    public interface ITweetRepository
    {
        IEnumerable<Tweet> AllTweets();

        IList<Tweet> UserAllTweets(string emailId);

        void AddTweet(Tweet tweet);

        void DeleteTweet(Tweet tweet);

        void Like(Tweet tweet);

        void Reply(Tweet tweet);
    }
}
