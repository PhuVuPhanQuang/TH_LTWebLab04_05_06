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
    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;

        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingdto)
        {
            var userId = User.Identity.GetUserId();
           
            if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingdto.FolloweeId))
                 return BadRequest("Following already exists!");

            var folowing = new Following
            {
                FolloweeId = userId,
                FollowerId = followingdto.FolloweeId,
                // Followee = _dbContext.Users.First(p => p.Id == followingdto.FolloweeId),
                //Follower = _dbContext.Users.First(p => p.Id == userId)
            };
            _dbContext.Followings.Add(folowing);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}