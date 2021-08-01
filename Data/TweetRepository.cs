using System.Collections.Generic;
using System.Linq;
using TweetApi.Models;

namespace TweetApi.Data
{
    public class TweetRepository : ITweetRepository
    {
        static Dictionary<string, List<Tweet>> userTweets = new Dictionary<string, List<Tweet>>();

        public void AddTweet(Tweet tweet)
        {
            var uts = userTweets.TryGetValue(tweet.Email, out List<Tweet> tws);
            if (!uts)
            {
                userTweets[tweet.Email] = new List<Tweet>() { tweet };
            }
            else
            {
                tws.Add(tweet);
            }
        }

        public IEnumerable<Tweet> AllTweets()
        {
            List<Tweet> allTweets = new List<Tweet>();
            foreach (KeyValuePair<string, List<Tweet>> twDict in userTweets)
            {
                allTweets.AddRange(twDict.Value);
            }

            return allTweets;
        }

        public void DeleteTweet(Tweet tweet)
        {
            List<Tweet> tweets = userTweets[tweet.Email];
            var tw = tweets?.Where(x => x.Id == tweet.Id).FirstOrDefault();
            if (tw != null)
            {
                tweets.Remove(tw);
            }
        }

        public void Like(Tweet tweet)
        {
            List<Tweet> tweets = userTweets[tweet.Email];
            var tw = tweets?.Where(x => x.Id == tweet.Id).FirstOrDefault();
            if (tw != null)
            {
                tw.Likes++;
            }
        }

        public void Reply(Tweet tweet)
        {
            throw new System.NotImplementedException();
        }

        public IList<Tweet> UserAllTweets(string emailId)
        {
            List<Tweet> allTweets = null;

            userTweets.TryGetValue(emailId, out allTweets);

            return allTweets;
        }
    }
}