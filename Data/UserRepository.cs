using System;
using System.Linq;
using TweetApi.Models;

namespace TweetApi.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;

        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Response Login(Login login)
        {
            User user = context.Users.Where(x => x.Email.Equals(login.Email) && x.Password.Equals(login.Password)).FirstOrDefault();

            if (user == null)
            {
                return new Response() { IsSuccess = false, Message = "Either User doesnot exists or password is incorrect.", Status = 200 };
            }
            else
            {
                return new Response() { IsSuccess = true, Message = "Login successful.", Status = 200 };
            }
        }

        public Response Register(User user)
        {
            User u = context.Users.Where(x => x.Email.Equals(user.Email)).FirstOrDefault();

            if (u == null)
            {
                this.context.Add(user);
                this.context.SaveChanges();
                return new Response() { IsSuccess = true, Message = "User registerd.", Status = 201 };
            }
            else
            {
                return new Response() { IsSuccess = false, Message = "user id already exists.", Status = 400 };
            }
        }
    }
}
