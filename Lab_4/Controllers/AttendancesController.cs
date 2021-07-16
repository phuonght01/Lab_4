using Lab_4.DTOs;
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
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var attendace = new Attendance
            {
                Courseid = attendanceDto.CourseId,
                AttendeeId = attendanceDto.attendeeId,
            };

            _dbContext.Attendances.Add(attendace);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
