using CoreAdmin.Platform.Entities;
using CoreAdmin.Security.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAdmin.Api.Controllers
{
    [Route("api/users")]
    public class UsersController : Controller
    {
        private readonly SecurityContext securityContext;

        public UsersController(SecurityContext securityContext)
        {
            this.securityContext = securityContext;
        }

        [HttpGet()]
        public IActionResult GetUsers()
        {
            List<User> users = new List<User>()
            {
                new User() {FirstName="Praveen", LastName="Namburi", Username="nlnpraveen", Email="nlnpraveen@gmail.com"},
                new User() {FirstName="Charvi", LastName="Namburi", Username="charvisrihyma", Email="charvisrihyma@gmail.com"},
                new User() {FirstName="Naithik", LastName="Namburi", Username="naithiknandasai", Email="naithiknandasai@gmail.com"}
            };

            using (securityContext)
            {
                users.ForEach(u => securityContext.Users.Add(u));
                securityContext.SaveChanges();
            }
            return Ok(users);

        }
    }
}
