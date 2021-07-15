using Lab_4.Models;
using Microsoft.AspNet.Identity;
using System.Web.Http;

namespace Lab_4.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;

        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend([FromBody] int courseId)
        {
            var attendace = new Attendance
            {
                Courseid = courseId,
                AttendeeId = User.Identity.GetUserId()
            };

            _dbContext.Attendaces.Add(attendace);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
