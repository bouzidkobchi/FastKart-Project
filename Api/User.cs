using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FastKart.Api
{
    public class UserController : Controller
    {
        /// <remarks>
        /// documentation ...
        /// </remarks>
        [HttpGet("/user")]
        public JsonResult Index()
        {
            var data = new
            {
                name = "bouzid" ,
                language = "C#",
                pltform = ".Net",
                isCrossPlatform = true,
            };

            return new JsonResult(data);
        }

        // search how to use optional parameter in swagger ui

        [HttpGet("/users/{count:int?}")]
        public JsonResult GetAllUsers(int? Count)
        {
            var users = new
            {
                user1 = new
                {
                    name = "boz",
                    firstName = "bouzid",
                    lastname = "kobchi"
                },

                user2 = new
                {
                    name = "yoc",
                    firstName = "youcef",
                    lastname = "kobchi"
                },

            };
            return new JsonResult(users);
        }
    }
}
