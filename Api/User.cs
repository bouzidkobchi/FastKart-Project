using FastKart.Data;
using FastKart.Data.Entities;
using FastKart.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FastKart.Api
{
    public class UserController : Controller 
    {
        private UserRepository Repo => new UserRepository(new AppDbContext());

        [HttpPost("/users")]
        public JsonResult AddUser([Required] string Email,[Required] string UserName,[Required] string Password, string phone)
        {
            var user = new User()
            {
                Email = Email,
                UserName = UserName,
                PasswordHash = Password,
                Phone = phone
            };
            int UserId = Repo.Add(user);
            return Json(new { UserId });
        }

        [HttpGet("/users")]
        public JsonResult GetAllUsers()
        {
            return Json(new {Users = Repo.GetAll()});
        }

        [HttpGet("/users/pages")]
        public JsonResult GetUsers(int page , int pageSize)
        {
            if(pageSize == -1)
                return Json(new { Users = Repo.GetAll(), Total = Repo.Count() });
            return Json(new { Users =  Repo.GetPage(page , pageSize)});
        }

        [HttpDelete("/users")]
        public JsonResult DeleteUser([Required] int UserId) 
        {
            Repo.Delete(UserId);
            return Json(new {Action = $"user of id {UserId} deleted seccufuly !"});
        }

        [HttpPut("/users")]
        public JsonResult UpdateUser(int UserId , string  UserName , string Password , string phone)
        {
            var user = Repo.GetById(UserId);

            if (user is null)
                return Json(new { action = "user not found" });

            if (UserName is not null) user.UserName = UserName;
            if (Password is not null) user.PasswordHash = Password;
            if (phone is not null) user.Phone = phone;

            Repo.Update(user);

            return Json(new { action = "user info updated seccufuly !" });
        }

        [HttpGet("/users/search")]
        public JsonResult SearchUser(string keyword) 
        {
            var users = new
            {
                usersByUsername = Repo.Filter(U => U.UserName.Split(' ').Contains(keyword)).ToList()
                //usersByEmail = Repo.Filter(U => U.Email.Contains(keyword)),
                //usersByPhone = Repo.Filter(U => U.Phone.Contains(keyword)),
            };

            return Json(users);
        }

        [HttpGet("/users/search/pages")]
        public JsonResult SearchUserPginated(string keyword) 
        {
            var users = new
            {
                users = Repo.Filter
                (
                    U => U.UserName.Contains(keyword)
                    || U.Email.Contains(keyword)
                    || U.Phone.Contains(keyword)
                )
            };

            return Json(users);
        }

        
    }
}
