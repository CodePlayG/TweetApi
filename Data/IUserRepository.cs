using TweetApi.Models;

namespace TweetApi.Data
{
    public interface IUserRepository
    {
        Response Login(Login login);

        Response Register(User user);
    } 
}