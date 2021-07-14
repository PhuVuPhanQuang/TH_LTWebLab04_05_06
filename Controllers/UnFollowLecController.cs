using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TH_LTWebLab04_05_06.DTOs;
using TH_LTWebLab04_05_06.Models;

namespace TH_LTWebLab04_05_06.Controllers
{
    public class UnFollowLecController : ApiController
    {
        ApplicationDbContext _dbContext;
        public UnFollowLecController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult UnFollow(FollowingDto followee)
        {
            string userId = User.Identity.GetUserId();

            Following temp = _dbContext.Followings.FirstOrDefault(p => p.FollowerId == userId && p.FolloweeId == followee.FolloweeId);

            _dbContext.Followings.Remove(temp);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
